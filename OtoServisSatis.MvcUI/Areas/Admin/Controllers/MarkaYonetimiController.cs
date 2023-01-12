using System.Net;
using System.Web.Mvc;
using OtoServisSatis.BL;
using OtoServisSatis.Entities;

namespace OtoServisSatis.MvcUI.Areas.Admin.Controllers
{
    public class MarkaYonetimiController : Controller
    {
        MarkaManager manager = new MarkaManager();

        // GET: Admin/MarkaYonetimi
        public ActionResult Index()
        {
            return View(manager.GetAll());
        }

        // GET: Admin/MarkaYonetimi/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marka marka = manager.Get(id.Value);
            if (marka == null)
            {
                return HttpNotFound();
            }
            return View(marka);
        }

        // GET: Admin/MarkaYonetimi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/MarkaYonetimi/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Adi")] Marka marka)
        {
            if (ModelState.IsValid)
            {
                manager.Add(marka);
                
                return RedirectToAction("Index");
            }

            return View(marka);
        }

        // GET: Admin/MarkaYonetimi/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marka marka = manager.Get(id.Value);
            if (marka == null)
            {
                return HttpNotFound();
            }
            return View(marka);
        }

        // POST: Admin/MarkaYonetimi/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Adi")] Marka marka)
        {
            if (ModelState.IsValid)
            {
                manager.Update(marka);
                return RedirectToAction("Index");
            }
            return View(marka);
        }

        // GET: Admin/MarkaYonetimi/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marka marka = manager.Get(id.Value);
            if (marka == null)
            {
                return HttpNotFound();
            }
            return View(marka);
        }

        // POST: Admin/MarkaYonetimi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Marka marka = manager.Get(id);
            manager.Delete(marka);
            return RedirectToAction("Index");
        }

        
    }
}

using OtoServisSatis.BL;
using OtoServisSatis.Entities;
using System;
using System.Web.Mvc;

namespace OtoServisSatis.MvcUI.Areas.Admin.Controllers
{
    public class AracYonetimiController : Controller
    {
        AracManager manager = new AracManager();
        MarkaManager markaManager = new MarkaManager();
        // GET: Admin/AracYonetimi
        public ActionResult Index()
        {
            return View(manager.GetAll());
        }

        public ActionResult Create() //Araç Ekleme Sayfası
        {
            ViewBag.MarkaId = new SelectList(markaManager.GetAll(), "Id","Adi");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Arac arac) // Post İşlemi: Araç parametresi giriliyor
        {
            try
            {
                if (ModelState.IsValid) // ModelState.IsValid: bize gelecek araç bilgisi geçerli bir validation a sahip mi?
                {
                    var sonuc = manager.Add(arac); //sayfanın ön yüzünden gelen arac bilgileri/arac entity sini ekliyoruz
                    if (sonuc > 0)
                    {
                        return RedirectToAction("Index"); //işlem başarılı ise index sayfasına dön
                    }
                }
            }
            catch (Exception)
            {

                ModelState.AddModelError("","Hata oluştu! Kayıt Eklenemedi!");
            }
            
            return View();
        }

        public ActionResult Edit(int? id) //Edit sayfasına id isminde bir parametre gelecek ma gelmeyedebilir ? soru işareti bu yüzden, nullable alan
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Arac arac = manager.Find(id.Value);
            if (arac==null)
            {
                return HttpNotFound();
            }
            ViewBag.MarkaId = new SelectList(markaManager.GetAll(), "Id", "Adi", arac.MarkaId );
            return View(arac);
        }

        [HttpPost]
        public ActionResult Edit(Arac arac) // Post İşlemi: Araç parametresi giriliyor
        {
            try
            {
                if (ModelState.IsValid) // ModelState.IsValid: bize gelecek araç bilgisi geçerli bir validation a sahip mi?
                {
                    var sonuc = manager.Update(arac); //sayfanın ön yüzünden gelen arac bilgileri/arac entity sini ekliyoruz
                    if (sonuc > 0)
                    {
                        return RedirectToAction("Index"); //işlem başarılı ise index sayfasına dön
                    }
                }
            }
            catch (Exception)
            {

                ModelState.AddModelError("", "Hata oluştu! Kayıt Eklenemedi!");
            }
            ViewBag.MarkaId = new SelectList(markaManager.GetAll(), "Id", "Adi", arac.MarkaId);
            return View(arac);
        }

        public ActionResult Delete(int? id) //Edit sayfasına id isminde bir parametre gelecek ma gelmeyedebilir ? soru işareti bu yüzden, nullable alan
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Arac arac = manager.Find(id.Value);
            if (arac == null)
            {
                return HttpNotFound();
            }
            return View(arac);
        }

        [HttpPost]
        public ActionResult Delete(int? id,string test) //Edit sayfasına id isminde bir parametre gelecek ma gelmeyedebilir ? soru işareti bu yüzden, nullable alan
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Arac arac = manager.Find(id.Value);
            if (arac == null)
            {
                return HttpNotFound();
            }
            try
            {
                manager.Delete(id.Value);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                ModelState.AddModelError("","Kayıt Silinemedi!");
            }
            return View(arac);
        }
    }
}
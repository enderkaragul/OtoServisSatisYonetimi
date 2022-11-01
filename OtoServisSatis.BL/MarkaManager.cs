using OtoServisSatis.Entities;
using OtoServisSatis.BL.Repositories;
using OtoServisSatis.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Migrations;

namespace OtoServisSatis.BL
{
    public class MarkaManager 
    {
        DatabaseContext context = new DatabaseContext();
        public List<Marka> GetAll()
        {
            return context.Markalar.ToList();
        }

        public int Add(Marka marka)
        {
            context.Markalar.Add(marka);
            return context.SaveChanges();
        }

        public int Update(Marka marka)
        {
            context.Markalar.AddOrUpdate(marka);
            return context.SaveChanges();
        }

        public int Delete(Marka marka)
        {
            context.Markalar.Remove(marka);
            return context.SaveChanges();
        }

        public Marka Get(int id) //Bu metot kendisine gönderilen id ye sahip markayı entity framework ün find metoduyla bulup geri dönrürür
        {
            return context.Markalar.Find(id);
        }



    }
}

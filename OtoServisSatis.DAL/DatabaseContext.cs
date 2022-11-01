using OtoServisSatis.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisSatis.DAL
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Arac> Arac { get; set; }

        public DbSet<Kullanici> Kullanicilar { get; set; }

        public DbSet<Marka> Markalar { get; set; }

        public DbSet<Rol> Roller { get; set; }

        public DbSet<Satis> Satislar { get; set; }

        public DbSet<Servis> Servisler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove < PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public class DatabaseInitialier : CreateDatabaseIfNotExists<DatabaseContext> //veri tabanı oluştuktan sonra devreye girecek sınıf
        {
            protected override void Seed(DatabaseContext context)
            {
                if (!context.Kullanicilar.Any())
                {
                    context.Kullanicilar.Add(new Kullanici()
                    {
                        AktifMi = true,
                        Adi = "Admin",
                        EklenmeTarihi = DateTime.Now,
                        Email = "admin@otoservissatis.tc",
                        KullaniciAdi = "admin",
                        Sifre = "123456"
                    });
                    context.SaveChanges();
                }
                base.Seed(context);
                
            }
        }
        public DatabaseContext() : base("name =DatabaseContext") //constructor
        {
            Database.SetInitializer(new DatabaseInitialier());
        }

    }
}
/*
 *EF de Migrationu aktif etme
 * *App.config dosyalarında (DAL katmanı ve Windowsapp katmanı ) connection stringi olşturuyoruz.
 * *PMC konsolunu view menusunden aktif ettik
 * *PMC konsolunda aktif proje olarak sağ üst menüden .DAL katmanı seçip enable-migrations yazıp enter a bastık
 * *DAL projesine add-migration migrationa ismi ile enter a basarak bir migration oluşturduk.
 * *migratiın, migrations klasörüne eklendikten sonra update-database diyerek veri tabanını localhost ta oluşturduk.
*/

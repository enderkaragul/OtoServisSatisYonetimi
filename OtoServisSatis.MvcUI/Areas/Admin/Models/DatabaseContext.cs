using OtoServisSatis.Entities;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace OtoServisSatis.MvcUI.Areas.Admin.Models
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
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public class DatabaseInitialier : CreateDatabaseIfNotExists<DatabaseContext> //veri tabanı oluştuktan sonra devreye girecek sınıf
        {
            protected override void Seed(DatabaseContext context)
            {
                base.Seed(context);
            }
        }
        public DatabaseContext() : base("name =DatabaseContext") //constructor
        {
            Database.SetInitializer(new DatabaseInitialier());
        }

        public System.Data.Entity.DbSet<OtoServisSatis.Entities.Musteri> Musteris { get; set; }
    }
}
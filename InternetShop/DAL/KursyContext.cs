using InternetShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace InternetShop.DAL
{
    public class KursyContext : DbContext
    {
        public KursyContext() : base("DefaultConnection")
        {


        }
        static KursyContext()
        {
            Database.SetInitializer<KursyContext>(new KursyInitializer());

        }

        public DbSet<Kurs> Kursy { get; set; }
        public DbSet<Kategoria> Kategorie { get; set; }
        public DbSet<Zamowienie> Zamowienia { get; set; }
        public DbSet<PozycjaZamowienia> PozycjeZamoweinia { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }




    }
}
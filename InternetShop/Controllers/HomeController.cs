using InternetShop.DAL;
using InternetShop.Models;
using InternetShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InternetShop.Controllers
{
    public class HomeController : Controller
    {
        private KursyContext db = new KursyContext();
        public ActionResult Index()
        {
            //Kategoria kategoria = new Kategoria { NazwaKategorii = "asp.net mvc", NazwaPlikuIkony = "asp.net mvc.png", Opiskategorii = "opis" };
            //db.Kategorie.Add(kategoria);
            //db.SaveChanges();
            var kategorie = db.Kategorie.ToList();

            var nowosci = db.Kursy.Where(a => !a.Ukryty).OrderByDescending(a => a.DataDodania).Take(3).ToList();
            var bestseller = db.Kursy.Where(a => !a.Ukryty && a.Bestsseller).OrderBy(a => Guid.NewGuid()).Take(3).ToList();
            var vm = new HomeViewModel()
            {
                Kategorie = kategorie,
                Nowosci = nowosci,
                Bestsellery = bestseller

            };


            return View(vm);
        }

        public ActionResult StronyStatyczne(string nazwa)
        {

            return View(nazwa);
        }



    }
}
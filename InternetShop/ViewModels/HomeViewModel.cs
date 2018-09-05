using InternetShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Kategoria> Kategorie { get; set; }
        public IEnumerable<Kurs> Nowosci { get; set; }
        public IEnumerable<Kurs> Bestsellery { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InternetShop.Controllers
{
    public class KoszykController : Controller
    {
        // GET: Koszyk
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DodajdoKoszyka(string id)
        {
            return View();
        }

    }
}
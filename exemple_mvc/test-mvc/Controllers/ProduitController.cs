﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test_mvc.Controllers
{
    public class ProduitController : Controller
    {
        // GET: Produit
        public ActionResult Index()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace exemple_mvc.Controllers
{
    public class MagazinController : Controller
    {
        // GET: Magazin
        public ActionResult Produits()
        {
            return View();
        }
        public ActionResult Article()
        {
            return View();
        }
    }
}
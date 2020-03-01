using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_Projet.Models; 

namespace ASP_Projet.Controllers
{
    public class ComputerController : Controller
    {
        // GET: Computer
        public ActionResult Afficher()
        {
            var mycomputer = new Computer
            {
                Name = "Lonovo",
                Price = 1500
            };
            return View(mycomputer);
        }
    }
}
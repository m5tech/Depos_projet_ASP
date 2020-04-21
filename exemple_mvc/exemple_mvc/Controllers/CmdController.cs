using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace exemple_mvc.Controllers
{
    public class CmdController : Controller
    {
        // GET: Cmd
        public ActionResult TypeClient()
        {
            return View();
        }
        public ActionResult TypeCmd()
        {
            return View();
        }
        public ActionResult echanger()
        {
            return View();
        }
        public ActionResult acheter()
        {
            return View();
        }
        public ActionResult sendinfo()
        {
            return View();
        }
        public ActionResult addservices()
        {
            return View();
        }
    }
}
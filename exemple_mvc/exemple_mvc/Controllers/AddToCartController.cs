using exemple_mvc.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace exemple_mvc.Controllers
{
    public class AddToCartController : Controller
    {
        // GET: AddToCart


        DB_ASP_ProjetEntities2 db = new DB_ASP_ProjetEntities2();
        // GET: AddToCart  
        public ActionResult Add(produit produit, string qty, int Id)
        {
            produit p = db.produit.Where(x => x.ID_PR == Id).SingleOrDefault();

            cart c = new cart();
            c.productid = p.ID_PR;
            c.price = (decimal)p.PRIX;
            c.qty = Convert.ToInt32(qty);
            c.bill = c.price * c.qty;
            c.productimg = p.IMAGE;
            c.productname = p.NAME_PRODUIT;
            if (Session["cart"] == null)
            {
                List<cart> li = new List<cart>();

                li.Add(c);
                Session["cart"] = li;
                ViewBag.cart = li.Count();


                Session["count"] = 1;


            }
            else
            {
                List<cart> li = (List<cart>)Session["cart"];
                li.Add(c);
                Session["cart"] = li;
                ViewBag.cart = li.Count();
                Session["count"] = Convert.ToInt32(Session["count"]) + 1;

            }
            return RedirectToAction("Show", "produits");


        }
        public ActionResult Myorder()
        {

            return View(model: (List<cart>)Session["cart"]);

        }
        public ActionResult Remove(cart produit, int Id)
        {
            List<cart> li = (List<cart>)Session["cart"];
            foreach (var item in li)
            {
                if (item.productid == Id)
                {
                    li.Remove(item);
                    break;
                }
            }
            Session["count"] = Convert.ToInt32(Session["count"]) - 1;
            if (li.Count() == 0)
            {
                Session["cart"] = null;
            }
            else
            {
                Session["cart"] = li;
            }
            
            return RedirectToAction("Myorder", "AddToCart");
        }
    }
}
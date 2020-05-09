using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using exemple_mvc.Models;

namespace exemple_mvc.Controllers
{
    public class produitsController : Controller
    {
        private DB_ASP_ProjetEntities2 db = new DB_ASP_ProjetEntities2();
        produit pr = new produit();
        // GET: produits
        public ActionResult Index()
        {
            return View(db.produit.ToList());
        }


        // GET: produits
        public ActionResult Show(string Search)
        {
            if (Search == null)
            {
                return View(db.produit);
            }
            else
            {
                return View(db.produit.Where(x => x.NAME_PRODUIT.Contains(Search)));
            }
                
            
        }
        // GET: ordinateur
        public ActionResult ordinateur(string Search)
        {
            if (Search == null)
            {
                return View(db.produit);
            }
            else
            {
                return View(db.produit.Where(x => x.NAME_PRODUIT.Contains(Search)));
            }

        }
        // GET: produits
        public ActionResult mobile(string Search)
        {
            if (Search == null)
            {
                return View(db.produit);
            }
            else
            {
                return View(db.produit.Where(x => x.NAME_PRODUIT.Contains(Search)));
            }

        }
        // GET: produits
        public ActionResult system(string Search)
        {
            if (Search == null)
            {
                return View(db.produit);
            }
            else
            {
                return View(db.produit.Where(x => x.NAME_PRODUIT.Contains(Search)));
            }
               
        }

        // GET: produits/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            produit produit = db.produit.Find(id);
            if (produit == null)
            {
                return HttpNotFound();
            }
            return View(produit);
        }
        public ActionResult ArticleInfo(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            produit produit = db.produit.Find(id);
            if (produit == null)
            {
                return HttpNotFound();
            }
            return View(produit);
        }

        // GET: produits/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: produits/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NAME_PRODUIT,PRIX,DESCRIPTION,IMAGE")] produit produit)
        {
            if (ModelState.IsValid)
            {
                db.produit.Add(produit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(produit);
        }

        // GET: produits/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            produit produit = db.produit.Find(id);
            if (produit == null)
            {
                return HttpNotFound();
            }
            return View(produit);
        }

        // POST: produits/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NAME_PRODUIT,PRIX,DESCRIPTION,IMAGE")] produit produit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(produit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(produit);
        }

        // GET: produits/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            produit produit = db.produit.Find(id);
            if (produit == null)
            {
                return HttpNotFound();
            }
            return View(produit);
        }

        // POST: produits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            produit produit = db.produit.Find(id);
            db.produit.Remove(produit);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}

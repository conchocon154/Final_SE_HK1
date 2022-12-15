using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class OrderprodsController : Controller
    {
        private DevConn db = new DevConn();

        // GET: Orderprods
        public ActionResult Index()
        {
            var orderprods = db.Orderprods.Include(o => o.Order).Include(o => o.Product);
            return View(orderprods.ToList());
        }

        // GET: Orderprods/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Orderprod orderprod = db.Orderprods.Find(id);
            if (orderprod == null)
            {
                return HttpNotFound();
            }
            return View(orderprod);
        }

        // GET: Orderprods/Create
        public ActionResult Create()
        {
            ViewBag.oid = new SelectList(db.Orders, "oid", "paidmethod");
            ViewBag.prodid = new SelectList(db.Products, "prodid", "prodname");
            return View();
        }

        // POST: Orderprods/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "oid,prodid,quantity")] Orderprod orderprod)
        {
            if (ModelState.IsValid)
            {
                db.Orderprods.Add(orderprod);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.oid = new SelectList(db.Orders, "oid", "paidmethod", orderprod.oid);
            ViewBag.prodid = new SelectList(db.Products, "prodid", "prodname", orderprod.prodid);
            return View(orderprod);
        }

        // GET: Orderprods/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Orderprod orderprod = db.Orderprods.Find(id);
            if (orderprod == null)
            {
                return HttpNotFound();
            }
            ViewBag.oid = new SelectList(db.Orders, "oid", "paidmethod", orderprod.oid);
            ViewBag.prodid = new SelectList(db.Products, "prodid", "prodname", orderprod.prodid);
            return View(orderprod);
        }

        // POST: Orderprods/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "oid,prodid,quantity")] Orderprod orderprod)
        {
            if (ModelState.IsValid)
            {
                db.Entry(orderprod).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.oid = new SelectList(db.Orders, "oid", "paidmethod", orderprod.oid);
            ViewBag.prodid = new SelectList(db.Products, "prodid", "prodname", orderprod.prodid);
            return View(orderprod);
        }

        // GET: Orderprods/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Orderprod orderprod = db.Orderprods.Find(id);
            if (orderprod == null)
            {
                return HttpNotFound();
            }
            return View(orderprod);
        }

        // POST: Orderprods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Orderprod orderprod = db.Orderprods.Find(id);
            db.Orderprods.Remove(orderprod);
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

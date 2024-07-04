using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NLDTk22cnt3_lession111DB_2210900065.Models;

namespace NLDTk22cnt3_lession111DB_2210900065.Controllers
{
    public class NLDTProductsController : Controller
    {
        private NLDTk22cnt3Lession11DbEntities db = new NLDTk22cnt3Lession11DbEntities();

        // GET: NLDTProducts
        public ActionResult NLDTIndex()
        {
            return View(db.NLDTProduct.ToList());
        }

        // GET: NLDTProducts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NLDTProduct nLDTProduct = db.NLDTProduct.Find(id);
            if (nLDTProduct == null)
            {
                return HttpNotFound();
            }
            return View(nLDTProduct);
        }

        // GET: NLDTProducts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NLDTProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NLDTid,NLDTProName,NLDTQty,NLDTPrice,NLDTCateid,NLDTActive")] NLDTProduct nLDTProduct)
        {
            if (ModelState.IsValid)
            {
                db.NLDTProduct.Add(nLDTProduct);
                db.SaveChanges();
                return RedirectToAction("NLDTIndex");
            }

            return View(nLDTProduct);
        }

        // GET: NLDTProducts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NLDTProduct nLDTProduct = db.NLDTProduct.Find(id);
            if (nLDTProduct == null)
            {
                return HttpNotFound();
            }
            return View(nLDTProduct);
        }

        // POST: NLDTProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NLDTid,NLDTProName,NLDTQty,NLDTPrice,NLDTCateid,NLDTActive")] NLDTProduct nLDTProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nLDTProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NLDTIndex");
            }
            return View(nLDTProduct);
        }

        // GET: NLDTProducts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NLDTProduct nLDTProduct = db.NLDTProduct.Find(id);
            if (nLDTProduct == null)
            {
                return HttpNotFound();
            }
            return View(nLDTProduct);
        }

        // POST: NLDTProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NLDTProduct nLDTProduct = db.NLDTProduct.Find(id);
            db.NLDTProduct.Remove(nLDTProduct);
            db.SaveChanges();
            return RedirectToAction("NLDTIndex");
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

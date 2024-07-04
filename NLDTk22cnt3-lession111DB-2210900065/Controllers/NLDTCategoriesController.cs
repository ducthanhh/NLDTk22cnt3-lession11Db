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
    public class NLDTCategoriesController : Controller
    {
        private NLDTk22cnt3Lession11DbEntities db = new NLDTk22cnt3Lession11DbEntities();

        // GET: NLDTCategories
        public ActionResult NLDTIndex()
        {
            return View(db.NLDTCategory.ToList());
        }

        // GET: NLDTCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NLDTCategory nLDTCategory = db.NLDTCategory.Find(id);
            if (nLDTCategory == null)
            {
                return HttpNotFound();
            }
            return View(nLDTCategory);
        }

        // GET: NLDTCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NLDTCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NLDTid,NLDTCreateName,NLDTStatus")] NLDTCategory nLDTCategory)
        {
            if (ModelState.IsValid)
            {
                db.NLDTCategory.Add(nLDTCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nLDTCategory);
        }

        // GET: NLDTCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NLDTCategory nLDTCategory = db.NLDTCategory.Find(id);
            if (nLDTCategory == null)
            {
                return HttpNotFound();
            }
            return View(nLDTCategory);
        }

        // POST: NLDTCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NLDTid,NLDTCreateName,NLDTStatus")] NLDTCategory nLDTCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nLDTCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nLDTCategory);
        }

        // GET: NLDTCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NLDTCategory nLDTCategory = db.NLDTCategory.Find(id);
            if (nLDTCategory == null)
            {
                return HttpNotFound();
            }
            return View(nLDTCategory);
        }

        // POST: NLDTCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NLDTCategory nLDTCategory = db.NLDTCategory.Find(id);
            db.NLDTCategory.Remove(nLDTCategory);
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

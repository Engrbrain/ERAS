using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ERAS.Models;
using ERAS.Models.EBOKOutputData;

namespace ERAS.Controllers
{
    public class BackAllocationQlestHeadersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationQlestHeaders
        public ActionResult Index()
        {
            return View(db.BackAllocationQlestHeader.ToList());
        }

        // GET: BackAllocationQlestHeaders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQlestHeader backAllocationQlestHeader = db.BackAllocationQlestHeader.Find(id);
            if (backAllocationQlestHeader == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQlestHeader);
        }

        // GET: BackAllocationQlestHeaders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationQlestHeaders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,FaultBlock,RSV,Well,Qlest")] BackAllocationQlestHeader backAllocationQlestHeader)
        {
            if (ModelState.IsValid)
            {
                db.BackAllocationQlestHeader.Add(backAllocationQlestHeader);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationQlestHeader);
        }

        // GET: BackAllocationQlestHeaders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQlestHeader backAllocationQlestHeader = db.BackAllocationQlestHeader.Find(id);
            if (backAllocationQlestHeader == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQlestHeader);
        }

        // POST: BackAllocationQlestHeaders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,FaultBlock,RSV,Well,Qlest")] BackAllocationQlestHeader backAllocationQlestHeader)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationQlestHeader).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationQlestHeader);
        }

        // GET: BackAllocationQlestHeaders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQlestHeader backAllocationQlestHeader = db.BackAllocationQlestHeader.Find(id);
            if (backAllocationQlestHeader == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQlestHeader);
        }

        // POST: BackAllocationQlestHeaders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationQlestHeader backAllocationQlestHeader = db.BackAllocationQlestHeader.Find(id);
            db.BackAllocationQlestHeader.Remove(backAllocationQlestHeader);
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

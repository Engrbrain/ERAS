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
    public class BackAllocationActualGORHeadersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationActualGORHeaders
        public ActionResult Index()
        {
            List<BackAllocationActualGORHeader> backAllocationActualGORHeader = new List<BackAllocationActualGORHeader>();

            backAllocationActualGORHeader = db.Database.SqlQuery<BackAllocationActualGORHeader>(
        "usp_GetBackAllocationActualGORHeader"
        ).ToList();
            return View(backAllocationActualGORHeader);
        }

        // GET: BackAllocationActualGORHeaders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationActualGORHeader backAllocationActualGORHeader = db.BackAllocationActualGORHeader.Find(id);
            if (backAllocationActualGORHeader == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationActualGORHeader);
        }

        // GET: BackAllocationActualGORHeaders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationActualGORHeaders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,ActualGOR")] BackAllocationActualGORHeader backAllocationActualGORHeader)
        {
            if (ModelState.IsValid)
            {
                db.BackAllocationActualGORHeader.Add(backAllocationActualGORHeader);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationActualGORHeader);
        }

        // GET: BackAllocationActualGORHeaders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationActualGORHeader backAllocationActualGORHeader = db.BackAllocationActualGORHeader.Find(id);
            if (backAllocationActualGORHeader == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationActualGORHeader);
        }

        // POST: BackAllocationActualGORHeaders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,ActualGOR")] BackAllocationActualGORHeader backAllocationActualGORHeader)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationActualGORHeader).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationActualGORHeader);
        }

        // GET: BackAllocationActualGORHeaders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationActualGORHeader backAllocationActualGORHeader = db.BackAllocationActualGORHeader.Find(id);
            if (backAllocationActualGORHeader == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationActualGORHeader);
        }

        // POST: BackAllocationActualGORHeaders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationActualGORHeader backAllocationActualGORHeader = db.BackAllocationActualGORHeader.Find(id);
            db.BackAllocationActualGORHeader.Remove(backAllocationActualGORHeader);
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

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
    public class BackAllocationQoestHeadersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationQoestHeaders
        public ActionResult Index()
        {
            List<BackAllocationQoestHeader> backAllocationQlestHeader = new List<BackAllocationQoestHeader>();

            backAllocationQlestHeader = db.Database.SqlQuery<BackAllocationQoestHeader>(
       "usp_GetQoestHeaderData"
       ).ToList();
            return View(backAllocationQlestHeader);
        }

        // GET: BackAllocationQoestHeaders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQoestHeader backAllocationQoestHeader = db.BackAllocationQoestHeader.Find(id);
            if (backAllocationQoestHeader == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQoestHeader);
        }

        // GET: BackAllocationQoestHeaders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationQoestHeaders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,ProdOil,wellTestPotential,WellTestActual")] BackAllocationQoestHeader backAllocationQoestHeader)
        {
            if (ModelState.IsValid)
            {
                db.BackAllocationQoestHeader.Add(backAllocationQoestHeader);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationQoestHeader);
        }

        // GET: BackAllocationQoestHeaders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQoestHeader backAllocationQoestHeader = db.BackAllocationQoestHeader.Find(id);
            if (backAllocationQoestHeader == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQoestHeader);
        }

        // POST: BackAllocationQoestHeaders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,ProdOil,wellTestPotential,WellTestActual")] BackAllocationQoestHeader backAllocationQoestHeader)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationQoestHeader).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationQoestHeader);
        }

        // GET: BackAllocationQoestHeaders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQoestHeader backAllocationQoestHeader = db.BackAllocationQoestHeader.Find(id);
            if (backAllocationQoestHeader == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQoestHeader);
        }

        // POST: BackAllocationQoestHeaders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationQoestHeader backAllocationQoestHeader = db.BackAllocationQoestHeader.Find(id);
            db.BackAllocationQoestHeader.Remove(backAllocationQoestHeader);
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

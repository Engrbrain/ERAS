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
    public class BackAllocationQoestsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationQoests
        public ActionResult Index()
        {
            List<BackAllocationQoest> backAllocationQoest = new List<BackAllocationQoest>();

            backAllocationQoest = db.Database.SqlQuery<BackAllocationQoest>(
        "usp_GetBackAllocationQoest"
        ).ToList();
            return View(backAllocationQoest);
        }

        // GET: BackAllocationQoests/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQoest backAllocationQoest = db.BackAllocationQoest.Find(id);
            if (backAllocationQoest == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQoest);
        }

        // GET: BackAllocationQoests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationQoests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,Well,Qoest")] BackAllocationQoest backAllocationQoest)
        {
            if (ModelState.IsValid)
            {
                db.BackAllocationQoest.Add(backAllocationQoest);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationQoest);
        }

        // GET: BackAllocationQoests/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQoest backAllocationQoest = db.BackAllocationQoest.Find(id);
            if (backAllocationQoest == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQoest);
        }

        // POST: BackAllocationQoests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,Well,Qoest")] BackAllocationQoest backAllocationQoest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationQoest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationQoest);
        }

        // GET: BackAllocationQoests/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQoest backAllocationQoest = db.BackAllocationQoest.Find(id);
            if (backAllocationQoest == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQoest);
        }

        // POST: BackAllocationQoests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationQoest backAllocationQoest = db.BackAllocationQoest.Find(id);
            db.BackAllocationQoest.Remove(backAllocationQoest);
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

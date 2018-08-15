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
    public class BackAllocationQgPotentialHeadersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationQgPotentialHeaders
        public ActionResult Index()
        {
            List<BackAllocationQgPotentialHeader> backAllocationQgPotentialHeader = new List<BackAllocationQgPotentialHeader>();

            backAllocationQgPotentialHeader = db.Database.SqlQuery<BackAllocationQgPotentialHeader>(
        "usp_GetBackAllocationQgPotentialHeader"
        ).ToList();
            return View(backAllocationQgPotentialHeader);
        }

        // GET: BackAllocationQgPotentialHeaders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQgPotentialHeader backAllocationQgPotentialHeader = db.BackAllocationQgPotentialHeader.Find(id);
            if (backAllocationQgPotentialHeader == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQgPotentialHeader);
        }

        // GET: BackAllocationQgPotentialHeaders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationQgPotentialHeaders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,QgPotential")] BackAllocationQgPotentialHeader backAllocationQgPotentialHeader)
        {
            if (ModelState.IsValid)
            {
                db.BackAllocationQgPotentialHeader.Add(backAllocationQgPotentialHeader);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationQgPotentialHeader);
        }

        // GET: BackAllocationQgPotentialHeaders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQgPotentialHeader backAllocationQgPotentialHeader = db.BackAllocationQgPotentialHeader.Find(id);
            if (backAllocationQgPotentialHeader == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQgPotentialHeader);
        }

        // POST: BackAllocationQgPotentialHeaders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,QgPotential")] BackAllocationQgPotentialHeader backAllocationQgPotentialHeader)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationQgPotentialHeader).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationQgPotentialHeader);
        }

        // GET: BackAllocationQgPotentialHeaders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQgPotentialHeader backAllocationQgPotentialHeader = db.BackAllocationQgPotentialHeader.Find(id);
            if (backAllocationQgPotentialHeader == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQgPotentialHeader);
        }

        // POST: BackAllocationQgPotentialHeaders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationQgPotentialHeader backAllocationQgPotentialHeader = db.BackAllocationQgPotentialHeader.Find(id);
            db.BackAllocationQgPotentialHeader.Remove(backAllocationQgPotentialHeader);
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

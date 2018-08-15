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
    public class BackAllocationBSWsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationBSWs
        public ActionResult Index()
        {
            List<BackAllocationBSW> backAllocationBSW = new List<BackAllocationBSW>();

            backAllocationBSW = db.Database.SqlQuery<BackAllocationBSW>(
        "usp_GetBackAllocationBSW"
        ).ToList();
            return View(backAllocationBSW);
        }

        // GET: BackAllocationBSWs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationBSW backAllocationBSW = db.BackAllocationBSW.Find(id);
            if (backAllocationBSW == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationBSW);
        }

        // GET: BackAllocationBSWs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationBSWs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,Well,BSW")] BackAllocationBSW backAllocationBSW)
        {
            if (ModelState.IsValid)
            {
                db.BackAllocationBSW.Add(backAllocationBSW);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationBSW);
        }

        // GET: BackAllocationBSWs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationBSW backAllocationBSW = db.BackAllocationBSW.Find(id);
            if (backAllocationBSW == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationBSW);
        }

        // POST: BackAllocationBSWs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,Well,BSW")] BackAllocationBSW backAllocationBSW)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationBSW).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationBSW);
        }

        // GET: BackAllocationBSWs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationBSW backAllocationBSW = db.BackAllocationBSW.Find(id);
            if (backAllocationBSW == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationBSW);
        }

        // POST: BackAllocationBSWs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationBSW backAllocationBSW = db.BackAllocationBSW.Find(id);
            db.BackAllocationBSW.Remove(backAllocationBSW);
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

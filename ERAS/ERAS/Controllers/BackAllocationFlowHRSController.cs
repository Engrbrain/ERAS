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
    public class BackAllocationFlowHRSController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationFlowHRS
        public ActionResult Index()
        {
            List<BackAllocationFlowHRS> backAllocationFlowHRS = new List<BackAllocationFlowHRS>();

            backAllocationFlowHRS = db.Database.SqlQuery<BackAllocationFlowHRS>(
        "usp_GetBackAllocationFlowHRS"
        ).ToList();
            return View(backAllocationFlowHRS);
        }

        // GET: BackAllocationFlowHRS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationFlowHRS backAllocationFlowHRS = db.BackAllocationFlowHRS.Find(id);
            if (backAllocationFlowHRS == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationFlowHRS);
        }

        // GET: BackAllocationFlowHRS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationFlowHRS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,Well,Uptime")] BackAllocationFlowHRS backAllocationFlowHRS)
        {
            if (ModelState.IsValid)
            {
                db.BackAllocationFlowHRS.Add(backAllocationFlowHRS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationFlowHRS);
        }

        // GET: BackAllocationFlowHRS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationFlowHRS backAllocationFlowHRS = db.BackAllocationFlowHRS.Find(id);
            if (backAllocationFlowHRS == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationFlowHRS);
        }

        // POST: BackAllocationFlowHRS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,Well,Uptime")] BackAllocationFlowHRS backAllocationFlowHRS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationFlowHRS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationFlowHRS);
        }

        // GET: BackAllocationFlowHRS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationFlowHRS backAllocationFlowHRS = db.BackAllocationFlowHRS.Find(id);
            if (backAllocationFlowHRS == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationFlowHRS);
        }

        // POST: BackAllocationFlowHRS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationFlowHRS backAllocationFlowHRS = db.BackAllocationFlowHRS.Find(id);
            db.BackAllocationFlowHRS.Remove(backAllocationFlowHRS);
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

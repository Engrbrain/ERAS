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
    public class BackAllocationBOPDsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationBOPDs
        public ActionResult Index()
        {
            List<BackAllocationBOPD> backAllocationBOPD = new List<BackAllocationBOPD>();

            backAllocationBOPD = db.Database.SqlQuery<BackAllocationBOPD>(
        "usp_GetBackAllocationBOPD"
        ).ToList();
            return View(backAllocationBOPD);
        }

        // GET: BackAllocationBOPDs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationBOPD backAllocationBOPD = db.BackAllocationBOPD.Find(id);
            if (backAllocationBOPD == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationBOPD);
        }

        // GET: BackAllocationBOPDs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationBOPDs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,Well,BOPD")] BackAllocationBOPD backAllocationBOPD)
        {
            if (ModelState.IsValid)
            {
                db.BackAllocationBOPD.Add(backAllocationBOPD);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationBOPD);
        }

        // GET: BackAllocationBOPDs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationBOPD backAllocationBOPD = db.BackAllocationBOPD.Find(id);
            if (backAllocationBOPD == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationBOPD);
        }

        // POST: BackAllocationBOPDs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,Well,BOPD")] BackAllocationBOPD backAllocationBOPD)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationBOPD).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationBOPD);
        }

        // GET: BackAllocationBOPDs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationBOPD backAllocationBOPD = db.BackAllocationBOPD.Find(id);
            if (backAllocationBOPD == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationBOPD);
        }

        // POST: BackAllocationBOPDs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationBOPD backAllocationBOPD = db.BackAllocationBOPD.Find(id);
            db.BackAllocationBOPD.Remove(backAllocationBOPD);
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

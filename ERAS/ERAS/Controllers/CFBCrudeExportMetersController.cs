using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ERAS.Models;
using ERAS.Models.EBOKDailyReport;

namespace ERAS.Controllers
{
    public class CFBCrudeExportMetersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CFBCrudeExportMeters
        public ActionResult Index()
        {
            return View(db.CFBCrudeExportMeters.ToList());
        }

        // GET: CFBCrudeExportMeters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CFBCrudeExportMeter cFBCrudeExportMeter = db.CFBCrudeExportMeters.Find(id);
            if (cFBCrudeExportMeter == null)
            {
                return HttpNotFound();
            }
            return View(cFBCrudeExportMeter);
        }

        // GET: CFBCrudeExportMeters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CFBCrudeExportMeters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,MeterName,CurrentEightHours,MeterFactor,GrossCorr,BSW,NetOil,ReportDate,UploadTime,TimeStamp,DayOftheWeek")] CFBCrudeExportMeter cFBCrudeExportMeter)
        {
            if (ModelState.IsValid)
            {
                db.CFBCrudeExportMeters.Add(cFBCrudeExportMeter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cFBCrudeExportMeter);
        }

        // GET: CFBCrudeExportMeters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CFBCrudeExportMeter cFBCrudeExportMeter = db.CFBCrudeExportMeters.Find(id);
            if (cFBCrudeExportMeter == null)
            {
                return HttpNotFound();
            }
            return View(cFBCrudeExportMeter);
        }

        // POST: CFBCrudeExportMeters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,MeterName,CurrentEightHours,MeterFactor,GrossCorr,BSW,NetOil,ReportDate,UploadTime,TimeStamp,DayOftheWeek")] CFBCrudeExportMeter cFBCrudeExportMeter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cFBCrudeExportMeter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cFBCrudeExportMeter);
        }

        // GET: CFBCrudeExportMeters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CFBCrudeExportMeter cFBCrudeExportMeter = db.CFBCrudeExportMeters.Find(id);
            if (cFBCrudeExportMeter == null)
            {
                return HttpNotFound();
            }
            return View(cFBCrudeExportMeter);
        }

        // POST: CFBCrudeExportMeters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CFBCrudeExportMeter cFBCrudeExportMeter = db.CFBCrudeExportMeters.Find(id);
            db.CFBCrudeExportMeters.Remove(cFBCrudeExportMeter);
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

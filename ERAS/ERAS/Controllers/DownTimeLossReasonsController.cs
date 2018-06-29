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
    public class DownTimeLossReasonsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: DownTimeLossReasons
        public ActionResult Index()
        {
            return View(db.DownTimeLossReasons.ToList());
        }

        // GET: DownTimeLossReasons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DownTimeLossReason downTimeLossReason = db.DownTimeLossReasons.Find(id);
            if (downTimeLossReason == null)
            {
                return HttpNotFound();
            }
            return View(downTimeLossReason);
        }

        // GET: DownTimeLossReasons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DownTimeLossReasons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,DownTimeReport,ReportDate,UploadTime,TimeStamp,DayOftheWeek")] DownTimeLossReason downTimeLossReason)
        {
            if (ModelState.IsValid)
            {
                db.DownTimeLossReasons.Add(downTimeLossReason);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(downTimeLossReason);
        }

        // GET: DownTimeLossReasons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DownTimeLossReason downTimeLossReason = db.DownTimeLossReasons.Find(id);
            if (downTimeLossReason == null)
            {
                return HttpNotFound();
            }
            return View(downTimeLossReason);
        }

        // POST: DownTimeLossReasons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,DownTimeReport,ReportDate,UploadTime,TimeStamp,DayOftheWeek")] DownTimeLossReason downTimeLossReason)
        {
            if (ModelState.IsValid)
            {
                db.Entry(downTimeLossReason).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(downTimeLossReason);
        }

        // GET: DownTimeLossReasons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DownTimeLossReason downTimeLossReason = db.DownTimeLossReasons.Find(id);
            if (downTimeLossReason == null)
            {
                return HttpNotFound();
            }
            return View(downTimeLossReason);
        }

        // POST: DownTimeLossReasons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DownTimeLossReason downTimeLossReason = db.DownTimeLossReasons.Find(id);
            db.DownTimeLossReasons.Remove(downTimeLossReason);
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

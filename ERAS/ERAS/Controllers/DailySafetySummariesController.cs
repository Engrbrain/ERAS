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
    public class DailySafetySummariesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: DailySafetySummaries
        public ActionResult Index()
        {
            return View(db.DailySafetySummaries.ToList());
        }

        // GET: DailySafetySummaries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailySafetySummary dailySafetySummary = db.DailySafetySummaries.Find(id);
            if (dailySafetySummary == null)
            {
                return HttpNotFound();
            }
            return View(dailySafetySummary);
        }

        // GET: DailySafetySummaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DailySafetySummaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,SafetyReport,ReportDate,UploadTime,TimeStamp,DayOftheWeek")] DailySafetySummary dailySafetySummary)
        {
            if (ModelState.IsValid)
            {
                db.DailySafetySummaries.Add(dailySafetySummary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dailySafetySummary);
        }

        // GET: DailySafetySummaries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailySafetySummary dailySafetySummary = db.DailySafetySummaries.Find(id);
            if (dailySafetySummary == null)
            {
                return HttpNotFound();
            }
            return View(dailySafetySummary);
        }

        // POST: DailySafetySummaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,SafetyReport,ReportDate,UploadTime,TimeStamp,DayOftheWeek")] DailySafetySummary dailySafetySummary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dailySafetySummary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dailySafetySummary);
        }

        // GET: DailySafetySummaries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailySafetySummary dailySafetySummary = db.DailySafetySummaries.Find(id);
            if (dailySafetySummary == null)
            {
                return HttpNotFound();
            }
            return View(dailySafetySummary);
        }

        // POST: DailySafetySummaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DailySafetySummary dailySafetySummary = db.DailySafetySummaries.Find(id);
            db.DailySafetySummaries.Remove(dailySafetySummary);
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

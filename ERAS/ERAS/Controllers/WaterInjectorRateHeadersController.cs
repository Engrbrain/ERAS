﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ERAS.Models;
using ERAS.Models.EBOKTranformedData;

namespace ERAS.Controllers
{
    public class WaterInjectorRateHeadersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: WaterInjectorRateHeaders
        public ActionResult Index()
        {
            return View(db.WaterInjectorRateHeader.ToList());
        }

        // GET: WaterInjectorRateHeaders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WaterInjectorRateHeader waterInjectorRateHeader = db.WaterInjectorRateHeader.Find(id);
            if (waterInjectorRateHeader == null)
            {
                return HttpNotFound();
            }
            return View(waterInjectorRateHeader);
        }

        // GET: WaterInjectorRateHeaders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WaterInjectorRateHeaders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,TotalWaterInj,WIJUptime,ReportDate,UploadTime,TimeStamp,DayOftheWeek")] WaterInjectorRateHeader waterInjectorRateHeader)
        {
            if (ModelState.IsValid)
            {
                db.WaterInjectorRateHeader.Add(waterInjectorRateHeader);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(waterInjectorRateHeader);
        }

        // GET: WaterInjectorRateHeaders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WaterInjectorRateHeader waterInjectorRateHeader = db.WaterInjectorRateHeader.Find(id);
            if (waterInjectorRateHeader == null)
            {
                return HttpNotFound();
            }
            return View(waterInjectorRateHeader);
        }

        // POST: WaterInjectorRateHeaders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,TotalWaterInj,WIJUptime,ReportDate,UploadTime,TimeStamp,DayOftheWeek")] WaterInjectorRateHeader waterInjectorRateHeader)
        {
            if (ModelState.IsValid)
            {
                db.Entry(waterInjectorRateHeader).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(waterInjectorRateHeader);
        }

        // GET: WaterInjectorRateHeaders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WaterInjectorRateHeader waterInjectorRateHeader = db.WaterInjectorRateHeader.Find(id);
            if (waterInjectorRateHeader == null)
            {
                return HttpNotFound();
            }
            return View(waterInjectorRateHeader);
        }

        // POST: WaterInjectorRateHeaders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WaterInjectorRateHeader waterInjectorRateHeader = db.WaterInjectorRateHeader.Find(id);
            db.WaterInjectorRateHeader.Remove(waterInjectorRateHeader);
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

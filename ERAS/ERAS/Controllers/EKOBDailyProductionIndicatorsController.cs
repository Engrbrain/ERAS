using System;
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
    public class EKOBDailyProductionIndicatorsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EKOBDailyProductionIndicators
        public ActionResult Index()
        {
            return View(db.EKOBDailyProductionIndicator.ToList());
        }


        // GET: EKOBDailyProductionIndicators/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EKOBDailyProductionIndicator eKOBDailyProductionIndicator = db.EKOBDailyProductionIndicator.Find(id);
            if (eKOBDailyProductionIndicator == null)
            {
                return HttpNotFound();
            }
            return View(eKOBDailyProductionIndicator);
        }

        // GET: EKOBDailyProductionIndicators/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EKOBDailyProductionIndicators/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Well,IndicatorDate,ChokeSize,Uptime,THP,FLP,BSW,BHT,AnnulusPressure,Frequency,SAND,GROSSAPI,NETAPI,PS,PWF,DP,OilBOPD,WaterBWPD,GASMMSCFD,BHP,PI,MaxWaterCut,GOR,REMARK,BLPD,GASMSCFD,ReportDate,UploadTime,TimeStamp,DayOftheWeek")] EKOBDailyProductionIndicator eKOBDailyProductionIndicator)
        {
            if (ModelState.IsValid)
            {
                db.EKOBDailyProductionIndicator.Add(eKOBDailyProductionIndicator);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eKOBDailyProductionIndicator);
        }

        // GET: EKOBDailyProductionIndicators/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EKOBDailyProductionIndicator eKOBDailyProductionIndicator = db.EKOBDailyProductionIndicator.Find(id);
            if (eKOBDailyProductionIndicator == null)
            {
                return HttpNotFound();
            }
            return View(eKOBDailyProductionIndicator);
        }

        // POST: EKOBDailyProductionIndicators/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Well,IndicatorDate,ChokeSize,Uptime,THP,FLP,BSW,BHT,AnnulusPressure,Frequency,SAND,GROSSAPI,NETAPI,PS,PWF,DP,OilBOPD,WaterBWPD,GASMMSCFD,BHP,PI,MaxWaterCut,GOR,REMARK,BLPD,GASMSCFD,ReportDate,UploadTime,TimeStamp,DayOftheWeek")] EKOBDailyProductionIndicator eKOBDailyProductionIndicator)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eKOBDailyProductionIndicator).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eKOBDailyProductionIndicator);
        }

        // GET: EKOBDailyProductionIndicators/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EKOBDailyProductionIndicator eKOBDailyProductionIndicator = db.EKOBDailyProductionIndicator.Find(id);
            if (eKOBDailyProductionIndicator == null)
            {
                return HttpNotFound();
            }
            return View(eKOBDailyProductionIndicator);
        }

        // POST: EKOBDailyProductionIndicators/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EKOBDailyProductionIndicator eKOBDailyProductionIndicator = db.EKOBDailyProductionIndicator.Find(id);
            db.EKOBDailyProductionIndicator.Remove(eKOBDailyProductionIndicator);
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

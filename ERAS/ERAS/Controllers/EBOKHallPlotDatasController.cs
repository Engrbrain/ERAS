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
    public class EBOKHallPlotDatasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EBOKHallPlotDatas
        public ActionResult Index()
        {
            List<EBOKHallPlotData> eBOKHallPlotData = new List<EBOKHallPlotData>();

            eBOKHallPlotData = db.Database.SqlQuery<EBOKHallPlotData>(
        "usp_GetEBOKHallPlotData"
        ).ToList();
            return View(eBOKHallPlotData);
        }

        // GET: EBOKHallPlotDatas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EBOKHallPlotData eBOKHallPlotData = db.EBOKHallPlotData.Find(id);
            if (eBOKHallPlotData == null)
            {
                return HttpNotFound();
            }
            return View(eBOKHallPlotData);
        }

        // GET: EBOKHallPlotDatas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EBOKHallPlotDatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Well,IndicatorDate,BWPD,CUMMMBBL,FTHP,THSP,DTDays,II,HallCal,HallCal2,HallCal3,HallCal4,Hall")] EBOKHallPlotData eBOKHallPlotData)
        {
            if (ModelState.IsValid)
            {
                db.EBOKHallPlotData.Add(eBOKHallPlotData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eBOKHallPlotData);
        }

        // GET: EBOKHallPlotDatas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EBOKHallPlotData eBOKHallPlotData = db.EBOKHallPlotData.Find(id);
            if (eBOKHallPlotData == null)
            {
                return HttpNotFound();
            }
            return View(eBOKHallPlotData);
        }

        // POST: EBOKHallPlotDatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Well,IndicatorDate,BWPD,CUMMMBBL,FTHP,THSP,DTDays,II,HallCal,HallCal2,HallCal3,HallCal4,Hall")] EBOKHallPlotData eBOKHallPlotData)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eBOKHallPlotData).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eBOKHallPlotData);
        }

        // GET: EBOKHallPlotDatas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EBOKHallPlotData eBOKHallPlotData = db.EBOKHallPlotData.Find(id);
            if (eBOKHallPlotData == null)
            {
                return HttpNotFound();
            }
            return View(eBOKHallPlotData);
        }

        // POST: EBOKHallPlotDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EBOKHallPlotData eBOKHallPlotData = db.EBOKHallPlotData.Find(id);
            db.EBOKHallPlotData.Remove(eBOKHallPlotData);
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

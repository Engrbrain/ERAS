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
    public class EBOKProductionSurveillancesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EBOKProductionSurveillances
        public ActionResult Index()
        {
            List<EBOKProductionSurveillance> eBOKProductionSurveillance = new List<EBOKProductionSurveillance>();

            eBOKProductionSurveillance = db.Database.SqlQuery<EBOKProductionSurveillance>(
        "usp_GetEBOKProductionSurveillance"
        ).ToList();
            return View(eBOKProductionSurveillance);
        }

        // GET: EBOKProductionSurveillances/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EBOKProductionSurveillance eBOKProductionSurveillance = db.EBOKProductionSurveillance.Find(id);
            if (eBOKProductionSurveillance == null)
            {
                return HttpNotFound();
            }
            return View(eBOKProductionSurveillance);
        }

        // GET: EBOKProductionSurveillances/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EBOKProductionSurveillances/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Well,IndicatorDate,BSW,OilBOPD,GASMSCFD,CumOil,CumOilkbbls")] EBOKProductionSurveillance eBOKProductionSurveillance)
        {
            if (ModelState.IsValid)
            {
                db.EBOKProductionSurveillance.Add(eBOKProductionSurveillance);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eBOKProductionSurveillance);
        }

        // GET: EBOKProductionSurveillances/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EBOKProductionSurveillance eBOKProductionSurveillance = db.EBOKProductionSurveillance.Find(id);
            if (eBOKProductionSurveillance == null)
            {
                return HttpNotFound();
            }
            return View(eBOKProductionSurveillance);
        }

        // POST: EBOKProductionSurveillances/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Well,IndicatorDate,BSW,OilBOPD,GASMSCFD,CumOil,CumOilkbbls")] EBOKProductionSurveillance eBOKProductionSurveillance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eBOKProductionSurveillance).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eBOKProductionSurveillance);
        }

        // GET: EBOKProductionSurveillances/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EBOKProductionSurveillance eBOKProductionSurveillance = db.EBOKProductionSurveillance.Find(id);
            if (eBOKProductionSurveillance == null)
            {
                return HttpNotFound();
            }
            return View(eBOKProductionSurveillance);
        }

        // POST: EBOKProductionSurveillances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EBOKProductionSurveillance eBOKProductionSurveillance = db.EBOKProductionSurveillance.Find(id);
            db.EBOKProductionSurveillance.Remove(eBOKProductionSurveillance);
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

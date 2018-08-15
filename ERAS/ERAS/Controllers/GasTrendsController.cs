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
    public class GasTrendsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: GasTrends
        public ActionResult Index()
        {
            List<GasTrend> gasTrend = new List<GasTrend>();

            gasTrend = db.Database.SqlQuery<GasTrend>(
        "usp_GetGasTrend"
        ).ToList();
            return View(gasTrend);
        }

        // GET: GasTrends/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GasTrend gasTrend = db.GasTrend.Find(id);
            if (gasTrend == null)
            {
                return HttpNotFound();
            }
            return View(gasTrend);
        }

        // GET: GasTrends/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GasTrends/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,WFBPROCESSTOTAL,TOTALGasLift,CalcuatedInjectedGas,MeteredGasInjected,GASUtilizationTotal,GASFLAREDTOTAL")] GasTrend gasTrend)
        {
            if (ModelState.IsValid)
            {
                db.GasTrend.Add(gasTrend);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gasTrend);
        }

        // GET: GasTrends/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GasTrend gasTrend = db.GasTrend.Find(id);
            if (gasTrend == null)
            {
                return HttpNotFound();
            }
            return View(gasTrend);
        }

        // POST: GasTrends/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,WFBPROCESSTOTAL,TOTALGasLift,CalcuatedInjectedGas,MeteredGasInjected,GASUtilizationTotal,GASFLAREDTOTAL")] GasTrend gasTrend)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gasTrend).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gasTrend);
        }

        // GET: GasTrends/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GasTrend gasTrend = db.GasTrend.Find(id);
            if (gasTrend == null)
            {
                return HttpNotFound();
            }
            return View(gasTrend);
        }

        // POST: GasTrends/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GasTrend gasTrend = db.GasTrend.Find(id);
            db.GasTrend.Remove(gasTrend);
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

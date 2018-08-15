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
    public class EBOKFieldProductionSummariesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EBOKFieldProductionSummaries
        public ActionResult Index()
        {
            return View(db.EBOKFieldProductionSummary.ToList());
        }



        // GET: EBOKFieldProductionSummaries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EBOKFieldProductionSummary eBOKFieldProductionSummary = db.EBOKFieldProductionSummary.Find(id);
            if (eBOKFieldProductionSummary == null)
            {
                return HttpNotFound();
            }
            return View(eBOKFieldProductionSummary);
        }

        // GET: EBOKFieldProductionSummaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EBOKFieldProductionSummaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,Uptime,ProdOil,CumProd,ProdGas,WFBAllocatedGas,WFBFlaringUptime,Gaslift,TotalProducedGas,CumGas,ProdWater,CumWater,EffluentOilInWater,API,ExportAPI,ExportTemp,ExportMetersReadingGross,ExportMetersReadingNet,FieldWaterCut,ExportWaterCut,PumpablecargoonBoard,Adjustment,TotalMeteredGasFlared,ViriniPremStockBalance,BSW,FieldGOR,AdjustedFieldGOR,WaterOverboard,FreeWaterReceived,WaterOverboardMOPU,UllageMeasurement,MOPUcorrectedmeterVariance,BSWManual,BSWAutosampler,OffloadVolume,OffloadBSW,OffloadAPI,Forecast,IdealDayRate,MarketExpectation,Budget,Deferment,EstmatedProdGas,TargetLC,TargetHC,TechnicalAllowable,CommercialAllowable,ActualProdGas,WeeklyAverage,ReportDate,UploadTime,TimeStamp,DayOftheWeek")] EBOKFieldProductionSummary eBOKFieldProductionSummary)
        {
            if (ModelState.IsValid)
            {
                db.EBOKFieldProductionSummary.Add(eBOKFieldProductionSummary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eBOKFieldProductionSummary);
        }

        // GET: EBOKFieldProductionSummaries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EBOKFieldProductionSummary eBOKFieldProductionSummary = db.EBOKFieldProductionSummary.Find(id);
            if (eBOKFieldProductionSummary == null)
            {
                return HttpNotFound();
            }
            return View(eBOKFieldProductionSummary);
        }

        // POST: EBOKFieldProductionSummaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,Uptime,ProdOil,CumProd,ProdGas,WFBAllocatedGas,WFBFlaringUptime,Gaslift,TotalProducedGas,CumGas,ProdWater,CumWater,EffluentOilInWater,API,ExportAPI,ExportTemp,ExportMetersReadingGross,ExportMetersReadingNet,FieldWaterCut,ExportWaterCut,PumpablecargoonBoard,Adjustment,TotalMeteredGasFlared,ViriniPremStockBalance,BSW,FieldGOR,AdjustedFieldGOR,WaterOverboard,FreeWaterReceived,WaterOverboardMOPU,UllageMeasurement,MOPUcorrectedmeterVariance,BSWManual,BSWAutosampler,OffloadVolume,OffloadBSW,OffloadAPI,Forecast,IdealDayRate,MarketExpectation,Budget,Deferment,EstmatedProdGas,TargetLC,TargetHC,TechnicalAllowable,CommercialAllowable,ActualProdGas,WeeklyAverage,ReportDate,UploadTime,TimeStamp,DayOftheWeek")] EBOKFieldProductionSummary eBOKFieldProductionSummary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eBOKFieldProductionSummary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eBOKFieldProductionSummary);
        }

        // GET: EBOKFieldProductionSummaries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EBOKFieldProductionSummary eBOKFieldProductionSummary = db.EBOKFieldProductionSummary.Find(id);
            if (eBOKFieldProductionSummary == null)
            {
                return HttpNotFound();
            }
            return View(eBOKFieldProductionSummary);
        }

        // POST: EBOKFieldProductionSummaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EBOKFieldProductionSummary eBOKFieldProductionSummary = db.EBOKFieldProductionSummary.Find(id);
            db.EBOKFieldProductionSummary.Remove(eBOKFieldProductionSummary);
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

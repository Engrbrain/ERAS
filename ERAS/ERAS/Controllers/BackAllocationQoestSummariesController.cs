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
    public class BackAllocationQoestSummariesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationQoestSummaries
        public ActionResult Index()
        {
            List<BackAllocationQoestSummary> backAllocationQoestSummary = new List<BackAllocationQoestSummary>();

            backAllocationQoestSummary = db.Database.SqlQuery<BackAllocationQoestSummary>(
       "usp_GetBackAllocationQoestSummaryData"
       ).ToList();
            return View(backAllocationQoestSummary);
        }

        // GET: BackAllocationQoestSummaries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQoestSummary backAllocationQoestSummary = db.BackAllocationQoestSummary.Find(id);
            if (backAllocationQoestSummary == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQoestSummary);
        }

        // GET: BackAllocationQoestSummaries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationQoestSummaries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,FaultBlock,RSV,ProdOil,wellTestPotential,WellTestActual")] BackAllocationQoestSummary backAllocationQoestSummary)
        {
            if (ModelState.IsValid)
            {
                db.BackAllocationQoestSummary.Add(backAllocationQoestSummary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationQoestSummary);
        }

        // GET: BackAllocationQoestSummaries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQoestSummary backAllocationQoestSummary = db.BackAllocationQoestSummary.Find(id);
            if (backAllocationQoestSummary == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQoestSummary);
        }

        // POST: BackAllocationQoestSummaries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,FaultBlock,RSV,ProdOil,wellTestPotential,WellTestActual")] BackAllocationQoestSummary backAllocationQoestSummary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationQoestSummary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationQoestSummary);
        }

        // GET: BackAllocationQoestSummaries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQoestSummary backAllocationQoestSummary = db.BackAllocationQoestSummary.Find(id);
            if (backAllocationQoestSummary == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQoestSummary);
        }

        // POST: BackAllocationQoestSummaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationQoestSummary backAllocationQoestSummary = db.BackAllocationQoestSummary.Find(id);
            db.BackAllocationQoestSummary.Remove(backAllocationQoestSummary);
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

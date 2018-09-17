using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ERAS.Models;
using ERAS.Models.EBOKOutputData;

namespace ERAS.Controllers
{
    public class BackAllocationActualGORsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationActualGORs
        public ActionResult Index(DateTime StartDate, DateTime EndDate)
        {
            List<BackAllocationActualGOR> backAllocationActualGOR = new List<BackAllocationActualGOR>();

            backAllocationActualGOR = db.Database.SqlQuery<BackAllocationActualGOR>(
        "exec dbo.[usp_GetBackAllocationActualGOR]@StartDate,@EndDate",
       new SqlParameter("@StartDate", StartDate),
       new SqlParameter("@EndDate", StartDate)
        ).ToList();
            return View(backAllocationActualGOR);
        }

        // GET: BackAllocationActualGORs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationActualGOR backAllocationActualGOR = db.BackAllocationActualGOR.Find(id);
            if (backAllocationActualGOR == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationActualGOR);
        }

        // GET: BackAllocationActualGORs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationActualGORs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,Well,ActualGOR")] BackAllocationActualGOR backAllocationActualGOR)
        {
            if (ModelState.IsValid)
            {
                db.BackAllocationActualGOR.Add(backAllocationActualGOR);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationActualGOR);
        }

        // GET: BackAllocationActualGORs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationActualGOR backAllocationActualGOR = db.BackAllocationActualGOR.Find(id);
            if (backAllocationActualGOR == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationActualGOR);
        }

        // POST: BackAllocationActualGORs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,Well,ActualGOR")] BackAllocationActualGOR backAllocationActualGOR)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationActualGOR).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationActualGOR);
        }

        // GET: BackAllocationActualGORs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationActualGOR backAllocationActualGOR = db.BackAllocationActualGOR.Find(id);
            if (backAllocationActualGOR == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationActualGOR);
        }

        // POST: BackAllocationActualGORs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationActualGOR backAllocationActualGOR = db.BackAllocationActualGOR.Find(id);
            db.BackAllocationActualGOR.Remove(backAllocationActualGOR);
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

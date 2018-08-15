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
    public class BackAllocationGasAllocationsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationGasAllocations
        public ActionResult Index()
        {
            List<BackAllocationGasAllocation> backAllocationGasAllocation = new List<BackAllocationGasAllocation>();

            backAllocationGasAllocation = db.Database.SqlQuery<BackAllocationGasAllocation>(
        "usp_GetBackAllocationGasAllocation"
        ).ToList();
            return View(backAllocationGasAllocation);
        }

        // GET: BackAllocationGasAllocations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationGasAllocation backAllocationGasAllocation = db.BackAllocationGasAllocation.Find(id);
            if (backAllocationGasAllocation == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationGasAllocation);
        }

        // GET: BackAllocationGasAllocations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationGasAllocations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,Well,GasAllocation")] BackAllocationGasAllocation backAllocationGasAllocation)
        {
            if (ModelState.IsValid)
            {
                db.BackAllocationGasAllocation.Add(backAllocationGasAllocation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationGasAllocation);
        }

        // GET: BackAllocationGasAllocations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationGasAllocation backAllocationGasAllocation = db.BackAllocationGasAllocation.Find(id);
            if (backAllocationGasAllocation == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationGasAllocation);
        }

        // POST: BackAllocationGasAllocations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,Well,GasAllocation")] BackAllocationGasAllocation backAllocationGasAllocation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationGasAllocation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationGasAllocation);
        }

        // GET: BackAllocationGasAllocations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationGasAllocation backAllocationGasAllocation = db.BackAllocationGasAllocation.Find(id);
            if (backAllocationGasAllocation == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationGasAllocation);
        }

        // POST: BackAllocationGasAllocations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationGasAllocation backAllocationGasAllocation = db.BackAllocationGasAllocation.Find(id);
            db.BackAllocationGasAllocation.Remove(backAllocationGasAllocation);
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

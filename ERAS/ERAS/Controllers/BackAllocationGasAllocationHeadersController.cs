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
    public class BackAllocationGasAllocationHeadersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationGasAllocationHeaders
        public ActionResult Index()
        {
            List<BackAllocationGasAllocationHeader> backAllocationGasAllocationHeader = new List<BackAllocationGasAllocationHeader>();

            backAllocationGasAllocationHeader = db.Database.SqlQuery<BackAllocationGasAllocationHeader>(
        "usp_GetBackAllocationGasAllocationHeader"
        ).ToList();
            return View(backAllocationGasAllocationHeader);
        }

        // GET: BackAllocationGasAllocationHeaders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationGasAllocationHeader backAllocationGasAllocationHeader = db.BackAllocationGasAllocationHeader.Find(id);
            if (backAllocationGasAllocationHeader == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationGasAllocationHeader);
        }

        // GET: BackAllocationGasAllocationHeaders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationGasAllocationHeaders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,GasAllocation,ActualGasProduced,GasDifference")] BackAllocationGasAllocationHeader backAllocationGasAllocationHeader)
        {
            if (ModelState.IsValid)
            {
                db.BackAllocationGasAllocationHeader.Add(backAllocationGasAllocationHeader);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationGasAllocationHeader);
        }

        // GET: BackAllocationGasAllocationHeaders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationGasAllocationHeader backAllocationGasAllocationHeader = db.BackAllocationGasAllocationHeader.Find(id);
            if (backAllocationGasAllocationHeader == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationGasAllocationHeader);
        }

        // POST: BackAllocationGasAllocationHeaders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,GasAllocation,ActualGasProduced,GasDifference")] BackAllocationGasAllocationHeader backAllocationGasAllocationHeader)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationGasAllocationHeader).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationGasAllocationHeader);
        }

        // GET: BackAllocationGasAllocationHeaders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationGasAllocationHeader backAllocationGasAllocationHeader = db.BackAllocationGasAllocationHeader.Find(id);
            if (backAllocationGasAllocationHeader == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationGasAllocationHeader);
        }

        // POST: BackAllocationGasAllocationHeaders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationGasAllocationHeader backAllocationGasAllocationHeader = db.BackAllocationGasAllocationHeader.Find(id);
            db.BackAllocationGasAllocationHeader.Remove(backAllocationGasAllocationHeader);
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

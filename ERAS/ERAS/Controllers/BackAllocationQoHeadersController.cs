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
    public class BackAllocationQoHeadersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationQoHeaders
        public ActionResult Index()
        {
            List<BackAllocationQoHeader> backAllocationQoHeader = new List<BackAllocationQoHeader>();

            backAllocationQoHeader = db.Database.SqlQuery<BackAllocationQoHeader>(
        "usp_GetBackAllocationQoHeader"
        ).ToList();
            return View(backAllocationQoHeader);
        }

        // GET: BackAllocationQoHeaders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQoHeader backAllocationQoHeader = db.BackAllocationQoHeader.Find(id);
            if (backAllocationQoHeader == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQoHeader);
        }

        // GET: BackAllocationQoHeaders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationQoHeaders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,Qo,ProdOil")] BackAllocationQoHeader backAllocationQoHeader)
        {
            if (ModelState.IsValid)
            {
                db.BackAllocationQoHeader.Add(backAllocationQoHeader);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationQoHeader);
        }

        // GET: BackAllocationQoHeaders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQoHeader backAllocationQoHeader = db.BackAllocationQoHeader.Find(id);
            if (backAllocationQoHeader == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQoHeader);
        }

        // POST: BackAllocationQoHeaders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,Qo,ProdOil")] BackAllocationQoHeader backAllocationQoHeader)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationQoHeader).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationQoHeader);
        }

        // GET: BackAllocationQoHeaders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQoHeader backAllocationQoHeader = db.BackAllocationQoHeader.Find(id);
            if (backAllocationQoHeader == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQoHeader);
        }

        // POST: BackAllocationQoHeaders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationQoHeader backAllocationQoHeader = db.BackAllocationQoHeader.Find(id);
            db.BackAllocationQoHeader.Remove(backAllocationQoHeader);
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

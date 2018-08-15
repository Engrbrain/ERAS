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
    public class BackAllocationQlinkHeadersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationQlinkHeaders
        public ActionResult Index()
        {
            List<BackAllocationQlinkHeader> backAllocationQlinkHeader = new List<BackAllocationQlinkHeader>();

            backAllocationQlinkHeader = db.Database.SqlQuery<BackAllocationQlinkHeader>(
        "usp_GetBackAllocationQlinkHeader"
        ).ToList();
            return View(backAllocationQlinkHeader);
        }

        // GET: BackAllocationQlinkHeaders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQlinkHeader backAllocationQlinkHeader = db.BackAllocationQlinkHeader.Find(id);
            if (backAllocationQlinkHeader == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQlinkHeader);
        }

        // GET: BackAllocationQlinkHeaders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationQlinkHeaders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,ProdOil,TotalQlink")] BackAllocationQlinkHeader backAllocationQlinkHeader)
        {
            if (ModelState.IsValid)
            {
                db.BackAllocationQlinkHeader.Add(backAllocationQlinkHeader);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationQlinkHeader);
        }

        // GET: BackAllocationQlinkHeaders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQlinkHeader backAllocationQlinkHeader = db.BackAllocationQlinkHeader.Find(id);
            if (backAllocationQlinkHeader == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQlinkHeader);
        }

        // POST: BackAllocationQlinkHeaders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,ProdOil,TotalQlink")] BackAllocationQlinkHeader backAllocationQlinkHeader)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationQlinkHeader).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationQlinkHeader);
        }

        // GET: BackAllocationQlinkHeaders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQlinkHeader backAllocationQlinkHeader = db.BackAllocationQlinkHeader.Find(id);
            if (backAllocationQlinkHeader == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQlinkHeader);
        }

        // POST: BackAllocationQlinkHeaders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationQlinkHeader backAllocationQlinkHeader = db.BackAllocationQlinkHeader.Find(id);
            db.BackAllocationQlinkHeader.Remove(backAllocationQlinkHeader);
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

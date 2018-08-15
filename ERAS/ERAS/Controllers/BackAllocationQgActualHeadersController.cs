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
    public class BackAllocationQgActualHeadersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationQgActualHeaders
        public ActionResult Index()
        {
            List<BackAllocationQgActualHeader> backAllocationQgActualHeader = new List<BackAllocationQgActualHeader>();

            backAllocationQgActualHeader = db.Database.SqlQuery<BackAllocationQgActualHeader>(
        "usp_GetBackAllocationQgActualHeader"
        ).ToList();
            return View(backAllocationQgActualHeader);
        }

        // GET: BackAllocationQgActualHeaders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQgActualHeader backAllocationQgActualHeader = db.BackAllocationQgActualHeader.Find(id);
            if (backAllocationQgActualHeader == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQgActualHeader);
        }

        // GET: BackAllocationQgActualHeaders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationQgActualHeaders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,QgActual")] BackAllocationQgActualHeader backAllocationQgActualHeader)
        {
            if (ModelState.IsValid)
            {
                db.BackAllocationQgActualHeader.Add(backAllocationQgActualHeader);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationQgActualHeader);
        }

        // GET: BackAllocationQgActualHeaders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQgActualHeader backAllocationQgActualHeader = db.BackAllocationQgActualHeader.Find(id);
            if (backAllocationQgActualHeader == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQgActualHeader);
        }

        // POST: BackAllocationQgActualHeaders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,QgActual")] BackAllocationQgActualHeader backAllocationQgActualHeader)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationQgActualHeader).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationQgActualHeader);
        }

        // GET: BackAllocationQgActualHeaders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQgActualHeader backAllocationQgActualHeader = db.BackAllocationQgActualHeader.Find(id);
            if (backAllocationQgActualHeader == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQgActualHeader);
        }

        // POST: BackAllocationQgActualHeaders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationQgActualHeader backAllocationQgActualHeader = db.BackAllocationQgActualHeader.Find(id);
            db.BackAllocationQgActualHeader.Remove(backAllocationQgActualHeader);
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

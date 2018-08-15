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
    public class BackAllocationQgActualsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationQgActuals
        public ActionResult Index()
        {
            List<BackAllocationQgActual> backAllocationQgActual = new List<BackAllocationQgActual>();

            backAllocationQgActual = db.Database.SqlQuery<BackAllocationQgActual>(
        "usp_GetBackAllocationQgActual"
        ).ToList();
            return View(backAllocationQgActual);
        }

        // GET: BackAllocationQgActuals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQgActual backAllocationQgActual = db.BackAllocationQgActual.Find(id);
            if (backAllocationQgActual == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQgActual);
        }

        // GET: BackAllocationQgActuals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationQgActuals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,Well,QgActual")] BackAllocationQgActual backAllocationQgActual)
        {
            if (ModelState.IsValid)
            {
                db.BackAllocationQgActual.Add(backAllocationQgActual);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationQgActual);
        }

        // GET: BackAllocationQgActuals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQgActual backAllocationQgActual = db.BackAllocationQgActual.Find(id);
            if (backAllocationQgActual == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQgActual);
        }

        // POST: BackAllocationQgActuals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,Well,QgActual")] BackAllocationQgActual backAllocationQgActual)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationQgActual).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationQgActual);
        }

        // GET: BackAllocationQgActuals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQgActual backAllocationQgActual = db.BackAllocationQgActual.Find(id);
            if (backAllocationQgActual == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQgActual);
        }

        // POST: BackAllocationQgActuals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationQgActual backAllocationQgActual = db.BackAllocationQgActual.Find(id);
            db.BackAllocationQgActual.Remove(backAllocationQgActual);
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

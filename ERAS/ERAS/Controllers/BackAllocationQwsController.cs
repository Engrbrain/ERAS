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
    public class BackAllocationQwsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationQws
        public ActionResult Index()
        {
            List<BackAllocationQw> backAllocationQw = new List<BackAllocationQw>();

            backAllocationQw = db.Database.SqlQuery<BackAllocationQw>(
        "usp_GetBackAllocationQw"
        ).ToList();
            return View(backAllocationQw);
        }

        // GET: BackAllocationQws/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQw backAllocationQw = db.BackAllocationQw.Find(id);
            if (backAllocationQw == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQw);
        }

        // GET: BackAllocationQws/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationQws/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,Well,Qw")] BackAllocationQw backAllocationQw)
        {
            if (ModelState.IsValid)
            {
                db.BackAllocationQw.Add(backAllocationQw);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationQw);
        }

        // GET: BackAllocationQws/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQw backAllocationQw = db.BackAllocationQw.Find(id);
            if (backAllocationQw == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQw);
        }

        // POST: BackAllocationQws/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,Well,Qw")] BackAllocationQw backAllocationQw)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationQw).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationQw);
        }

        // GET: BackAllocationQws/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQw backAllocationQw = db.BackAllocationQw.Find(id);
            if (backAllocationQw == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQw);
        }

        // POST: BackAllocationQws/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationQw backAllocationQw = db.BackAllocationQw.Find(id);
            db.BackAllocationQw.Remove(backAllocationQw);
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

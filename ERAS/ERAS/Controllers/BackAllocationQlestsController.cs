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
    public class BackAllocationQlestsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationQlests
        public ActionResult Index()
        {
            List<BackAllocationQlest> backAllocationQlest = new List<BackAllocationQlest>();

            backAllocationQlest = db.Database.SqlQuery<BackAllocationQlest>(
        "usp_GetBackAllocationQlest"
        ).ToList();
            return View(backAllocationQlest);
        }

        // GET: BackAllocationQlests/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQlest backAllocationQlest = db.BackAllocationQlest.Find(id);
            if (backAllocationQlest == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQlest);
        }

        // GET: BackAllocationQlests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationQlests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,Well,Qlest")] BackAllocationQlest backAllocationQlest)
        {
            if (ModelState.IsValid)
            {
                db.BackAllocationQlest.Add(backAllocationQlest);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationQlest);
        }

        // GET: BackAllocationQlests/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQlest backAllocationQlest = db.BackAllocationQlest.Find(id);
            if (backAllocationQlest == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQlest);
        }

        // POST: BackAllocationQlests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,Well,Qlest")] BackAllocationQlest backAllocationQlest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationQlest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationQlest);
        }

        // GET: BackAllocationQlests/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQlest backAllocationQlest = db.BackAllocationQlest.Find(id);
            if (backAllocationQlest == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQlest);
        }

        // POST: BackAllocationQlests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationQlest backAllocationQlest = db.BackAllocationQlest.Find(id);
            db.BackAllocationQlest.Remove(backAllocationQlest);
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

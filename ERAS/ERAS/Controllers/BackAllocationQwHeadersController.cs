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
    public class BackAllocationQwHeadersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationQwHeaders
        public ActionResult Index()
        {
            List<BackAllocationQwHeader> backAllocationQwHeader = new List<BackAllocationQwHeader>();

            backAllocationQwHeader = db.Database.SqlQuery<BackAllocationQwHeader>(
        "usp_GetBackAllocationQwHeader"
        ).ToList();
            return View(backAllocationQwHeader);
        }

        // GET: BackAllocationQwHeaders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQwHeader backAllocationQwHeader = db.BackAllocationQwHeader.Find(id);
            if (backAllocationQwHeader == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQwHeader);
        }

        // GET: BackAllocationQwHeaders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationQwHeaders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,Qw")] BackAllocationQwHeader backAllocationQwHeader)
        {
            if (ModelState.IsValid)
            {
                db.BackAllocationQwHeader.Add(backAllocationQwHeader);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationQwHeader);
        }

        // GET: BackAllocationQwHeaders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQwHeader backAllocationQwHeader = db.BackAllocationQwHeader.Find(id);
            if (backAllocationQwHeader == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQwHeader);
        }

        // POST: BackAllocationQwHeaders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,Qw")] BackAllocationQwHeader backAllocationQwHeader)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationQwHeader).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationQwHeader);
        }

        // GET: BackAllocationQwHeaders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQwHeader backAllocationQwHeader = db.BackAllocationQwHeader.Find(id);
            if (backAllocationQwHeader == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQwHeader);
        }

        // POST: BackAllocationQwHeaders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationQwHeader backAllocationQwHeader = db.BackAllocationQwHeader.Find(id);
            db.BackAllocationQwHeader.Remove(backAllocationQwHeader);
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

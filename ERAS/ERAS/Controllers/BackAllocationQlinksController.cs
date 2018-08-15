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
    public class BackAllocationQlinksController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationQlinks
        public ActionResult Index()
        {
            List<BackAllocationQlink> backAllocationQlink = new List<BackAllocationQlink>();

            backAllocationQlink = db.Database.SqlQuery<BackAllocationQlink>(
        "usp_GetBackAllocationQlink"
        ).ToList();
            return View(backAllocationQlink);
        }

        // GET: BackAllocationQlinks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQlink backAllocationQlink = db.BackAllocationQlink.Find(id);
            if (backAllocationQlink == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQlink);
        }

        // GET: BackAllocationQlinks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationQlinks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,Well,Qlink")] BackAllocationQlink backAllocationQlink)
        {
            if (ModelState.IsValid)
            {
                db.BackAllocationQlink.Add(backAllocationQlink);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationQlink);
        }

        // GET: BackAllocationQlinks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQlink backAllocationQlink = db.BackAllocationQlink.Find(id);
            if (backAllocationQlink == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQlink);
        }

        // POST: BackAllocationQlinks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,Well,Qlink")] BackAllocationQlink backAllocationQlink)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationQlink).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationQlink);
        }

        // GET: BackAllocationQlinks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQlink backAllocationQlink = db.BackAllocationQlink.Find(id);
            if (backAllocationQlink == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQlink);
        }

        // POST: BackAllocationQlinks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationQlink backAllocationQlink = db.BackAllocationQlink.Find(id);
            db.BackAllocationQlink.Remove(backAllocationQlink);
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

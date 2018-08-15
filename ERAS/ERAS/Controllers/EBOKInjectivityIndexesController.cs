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
    public class EBOKInjectivityIndexesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EBOKInjectivityIndexes
        public ActionResult Index()
        {
            List<EBOKInjectivityIndex> eBOKInjectivityIndex = new List<EBOKInjectivityIndex>();

            eBOKInjectivityIndex = db.Database.SqlQuery<EBOKInjectivityIndex>(
        "usp_GetEBOKInjectivityIndex"
        ).ToList();
            return View(eBOKInjectivityIndex);
        }

        // GET: EBOKInjectivityIndexes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EBOKInjectivityIndex eBOKInjectivityIndex = db.EBOKInjectivityIndex.Find(id);
            if (eBOKInjectivityIndex == null)
            {
                return HttpNotFound();
            }
            return View(eBOKInjectivityIndex);
        }

        // GET: EBOKInjectivityIndexes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EBOKInjectivityIndexes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Well,UpTime,IndicatorDate,INJRate,THIP,THSP,ScaledupRate,InjectivityIndex")] EBOKInjectivityIndex eBOKInjectivityIndex)
        {
            if (ModelState.IsValid)
            {
                db.EBOKInjectivityIndex.Add(eBOKInjectivityIndex);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eBOKInjectivityIndex);
        }

        // GET: EBOKInjectivityIndexes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EBOKInjectivityIndex eBOKInjectivityIndex = db.EBOKInjectivityIndex.Find(id);
            if (eBOKInjectivityIndex == null)
            {
                return HttpNotFound();
            }
            return View(eBOKInjectivityIndex);
        }

        // POST: EBOKInjectivityIndexes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Well,UpTime,IndicatorDate,INJRate,THIP,THSP,ScaledupRate,InjectivityIndex")] EBOKInjectivityIndex eBOKInjectivityIndex)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eBOKInjectivityIndex).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eBOKInjectivityIndex);
        }

        // GET: EBOKInjectivityIndexes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EBOKInjectivityIndex eBOKInjectivityIndex = db.EBOKInjectivityIndex.Find(id);
            if (eBOKInjectivityIndex == null)
            {
                return HttpNotFound();
            }
            return View(eBOKInjectivityIndex);
        }

        // POST: EBOKInjectivityIndexes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EBOKInjectivityIndex eBOKInjectivityIndex = db.EBOKInjectivityIndex.Find(id);
            db.EBOKInjectivityIndex.Remove(eBOKInjectivityIndex);
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

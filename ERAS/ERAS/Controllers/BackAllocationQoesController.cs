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
    public class BackAllocationQoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationQoes
        public ActionResult Index()
        {
            List<BackAllocationQo> backAllocationQo = new List<BackAllocationQo>();

            backAllocationQo = db.Database.SqlQuery<BackAllocationQo>(
        "usp_GetBackAllocationQo"
        ).ToList();
            return View(backAllocationQo);
        }

        // GET: BackAllocationQoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQo backAllocationQo = db.BackAllocationQo.Find(id);
            if (backAllocationQo == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQo);
        }

        // GET: BackAllocationQoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BackAllocationQoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,Well,Qo")] BackAllocationQo backAllocationQo)
        {
            if (ModelState.IsValid)
            {
                db.BackAllocationQo.Add(backAllocationQo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backAllocationQo);
        }

        // GET: BackAllocationQoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQo backAllocationQo = db.BackAllocationQo.Find(id);
            if (backAllocationQo == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQo);
        }

        // POST: BackAllocationQoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,Well,Qo")] BackAllocationQo backAllocationQo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backAllocationQo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backAllocationQo);
        }

        // GET: BackAllocationQoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BackAllocationQo backAllocationQo = db.BackAllocationQo.Find(id);
            if (backAllocationQo == null)
            {
                return HttpNotFound();
            }
            return View(backAllocationQo);
        }

        // POST: BackAllocationQoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BackAllocationQo backAllocationQo = db.BackAllocationQo.Find(id);
            db.BackAllocationQo.Remove(backAllocationQo);
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

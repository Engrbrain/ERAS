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
    public class PressurePlotTCMsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PressurePlotTCMs
        public ActionResult Index()
        {
            List<PressurePlotTCM> pressurePlotTCM = new List<PressurePlotTCM>();

            pressurePlotTCM = db.Database.SqlQuery<PressurePlotTCM>(
        "[usp_GetPressurePlotTCM"
        ).ToList();
            return View(pressurePlotTCM);
        }

        // GET: PressurePlotTCMs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PressurePlotTCM pressurePlotTCM = db.PressurePlotTCM.Find(id);
            if (pressurePlotTCM == null)
            {
                return HttpNotFound();
            }
            return View(pressurePlotTCM);
        }

        // GET: PressurePlotTCMs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PressurePlotTCMs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IndicatorDate,RSV,Well,PWF")] PressurePlotTCM pressurePlotTCM)
        {
            if (ModelState.IsValid)
            {
                db.PressurePlotTCM.Add(pressurePlotTCM);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pressurePlotTCM);
        }

        // GET: PressurePlotTCMs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PressurePlotTCM pressurePlotTCM = db.PressurePlotTCM.Find(id);
            if (pressurePlotTCM == null)
            {
                return HttpNotFound();
            }
            return View(pressurePlotTCM);
        }

        // POST: PressurePlotTCMs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IndicatorDate,RSV,Well,PWF")] PressurePlotTCM pressurePlotTCM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pressurePlotTCM).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pressurePlotTCM);
        }

        // GET: PressurePlotTCMs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PressurePlotTCM pressurePlotTCM = db.PressurePlotTCM.Find(id);
            if (pressurePlotTCM == null)
            {
                return HttpNotFound();
            }
            return View(pressurePlotTCM);
        }

        // POST: PressurePlotTCMs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PressurePlotTCM pressurePlotTCM = db.PressurePlotTCM.Find(id);
            db.PressurePlotTCM.Remove(pressurePlotTCM);
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

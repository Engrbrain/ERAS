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
using System.Data.SqlClient;

namespace ERAS.Controllers
{
    public class BackAllocationQgPotentialSummariesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationQgPotentialSummaries
        public ActionResult Index(DateTime? StartDate, DateTime? EndDate)
        {
            if (StartDate == null)
            {
                return View("Index", "ReportParameters");
            }
            else
            {
                List<BackAllocationQgPotentialSummary> backAllocationActualGORHeader = new List<BackAllocationQgPotentialSummary>();

                backAllocationActualGORHeader = db.Database.SqlQuery<BackAllocationQgPotentialSummary>(
            "exec dbo.[usp_GetBackAllocationQgPotentialSummary] @StartDate,@EndDate",
           new SqlParameter("@StartDate", StartDate),
           new SqlParameter("@EndDate", StartDate)
            ).ToList();
                return View(backAllocationActualGORHeader);
            }
        }

        public ActionResult FilterReport(ReportParameter model)
        {
            var StartDate = model.StartDate.Date;
            var EndDate = model.EndDate.Date;
            List<BackAllocationQgPotentialSummary> backAllocationActualGORHeader = new List<BackAllocationQgPotentialSummary>();

            backAllocationActualGORHeader = db.Database.SqlQuery<BackAllocationQgPotentialSummary>(
        "exec dbo.[usp_GetBackAllocationQgPotentialSummary] @StartDate,@EndDate",
       new SqlParameter("@StartDate", StartDate),
       new SqlParameter("@EndDate", StartDate)
        ).ToList();
            return View("Index", backAllocationActualGORHeader);
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


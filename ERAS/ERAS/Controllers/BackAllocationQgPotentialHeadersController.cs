using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ERAS.Models;
using ERAS.Models.EBOKOutputData;

namespace ERAS.Controllers
{
    public class BackAllocationQgPotentialHeadersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationQgPotentialHeaders
        public ActionResult Index(DateTime? StartDate, DateTime? EndDate)
        {
            if (StartDate == null)
            {
                return View("Index", "ReportParameters");
            }
            else
            {
                List<BackAllocationQgPotentialHeader> backAllocationQgPotentialHeader = new List<BackAllocationQgPotentialHeader>();

                backAllocationQgPotentialHeader = db.Database.SqlQuery<BackAllocationQgPotentialHeader>(
            "exec dbo.[usp_GetBackAllocationQgPotentialHeader] @StartDate,@EndDate",
           new SqlParameter("@StartDate", StartDate),
           new SqlParameter("@EndDate", StartDate)
            ).ToList();
                return View(backAllocationQgPotentialHeader);
            }
        }

        public ActionResult FilterReport(ReportParameter model)
        {
            var StartDate = model.StartDate.Date;
            var EndDate = model.EndDate.Date;
            List<BackAllocationQgPotentialHeader> backAllocationQgPotentialHeader = new List<BackAllocationQgPotentialHeader>();

            backAllocationQgPotentialHeader = db.Database.SqlQuery<BackAllocationQgPotentialHeader>(
        "exec dbo.[usp_GetBackAllocationQgPotentialHeader] @StartDate,@EndDate",
       new SqlParameter("@StartDate", StartDate),
       new SqlParameter("@EndDate", StartDate)
        ).ToList();
            return View("Index", backAllocationQgPotentialHeader);
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

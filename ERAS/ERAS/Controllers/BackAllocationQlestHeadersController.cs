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
    public class BackAllocationQlestHeadersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationQlestHeaders
        public ActionResult Index(DateTime? StartDate, DateTime? EndDate)
        {
            if (StartDate == null)
            {
                return View("Index", "ReportParameters");
            }
            else
            {
                List<BackAllocationQlestHeader> backAllocationQlestHeader = new List<BackAllocationQlestHeader>();

                backAllocationQlestHeader = db.Database.SqlQuery<BackAllocationQlestHeader>(
            "exec dbo.[usp_GetBackAllocationQlestHeader] @StartDate,@EndDate",
           new SqlParameter("@StartDate", StartDate),
           new SqlParameter("@EndDate", StartDate)
            ).ToList();
                return View(backAllocationQlestHeader);
            }
        }

        public ActionResult FilterReport(ReportParameter model)
        {
            var StartDate = model.StartDate.Date;
            var EndDate = model.EndDate.Date;
            List<BackAllocationQlestHeader> backAllocationQlestHeader = new List<BackAllocationQlestHeader>();

            backAllocationQlestHeader = db.Database.SqlQuery<BackAllocationQlestHeader>(
        "exec dbo.[usp_GetBackAllocationQlestHeader] @StartDate,@EndDate",
       new SqlParameter("@StartDate", StartDate),
       new SqlParameter("@EndDate", StartDate)
        ).ToList();
            return View("Index", backAllocationQlestHeader);
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

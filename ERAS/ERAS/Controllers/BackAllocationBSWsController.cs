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
    public class BackAllocationBSWsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationBSWs
        public ActionResult Index(DateTime? StartDate, DateTime? EndDate)
        {
            if (StartDate == null)
            {
                return View("Index", "ReportParameters");
            }
            else
            {
                List<BackAllocationBSW> backAllocationBSW = new List<BackAllocationBSW>();

                backAllocationBSW = db.Database.SqlQuery<BackAllocationBSW>(
            "exec dbo.[usp_GetBackAllocationBSW] @StartDate,@EndDate",
           new SqlParameter("@StartDate", StartDate),
           new SqlParameter("@EndDate", StartDate)
            ).ToList();
                return View(backAllocationBSW);
            }
        }

        public ActionResult FilterReport(ReportParameter model)
        {
            var StartDate = model.StartDate.Date;
            var EndDate = model.EndDate.Date;
            List<BackAllocationBSW> backAllocationBSW = new List<BackAllocationBSW>();

            backAllocationBSW = db.Database.SqlQuery<BackAllocationBSW>(
        "exec dbo.[usp_GetBackAllocationBSW] @StartDate,@EndDate",
       new SqlParameter("@StartDate", StartDate),
       new SqlParameter("@EndDate", StartDate)
        ).ToList();
            return View("Index", backAllocationBSW);
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

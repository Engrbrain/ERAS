﻿using System;
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
    public class BackAllocationQlinkHeadersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BackAllocationQlinkHeaders
        public ActionResult Index(DateTime? StartDate, DateTime? EndDate)
        {
            if (StartDate == null)
            {
                return View("Index", "ReportParameters");
            }
            else
            {
                List<BackAllocationQlinkHeader> backAllocationQlinkHeader = new List<BackAllocationQlinkHeader>();

                backAllocationQlinkHeader = db.Database.SqlQuery<BackAllocationQlinkHeader>(
            "exec dbo.[usp_GetBackAllocationQlinkHeader] @StartDate,@EndDate",
           new SqlParameter("@StartDate", StartDate),
           new SqlParameter("@EndDate", StartDate)
            ).ToList();
                return View(backAllocationQlinkHeader);
            }
        }

        public ActionResult FilterReport(ReportParameter model)
        {
            var StartDate = model.StartDate.Date;
            var EndDate = model.EndDate.Date;
            List<BackAllocationQlinkHeader> backAllocationQlinkHeader = new List<BackAllocationQlinkHeader>();

            backAllocationQlinkHeader = db.Database.SqlQuery<BackAllocationQlinkHeader>(
        "exec dbo.[usp_GetBackAllocationQlinkHeader] @StartDate,@EndDate",
       new SqlParameter("@StartDate", StartDate),
       new SqlParameter("@EndDate", StartDate)
        ).ToList();
            return View("Index", backAllocationQlinkHeader);
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


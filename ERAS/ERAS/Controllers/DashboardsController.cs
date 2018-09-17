using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERAS.Controllers
{
    public class DashboardsController : Controller
    {
        // GET: Dashboards
        public ActionResult EBOKDailyReportDashboard()
        {
            return View();
        }

        public ActionResult EBOKDailyProductionReportDashboard()
        {
            return View();
        }

        public ActionResult WaterInjectorRateDashboard()
        {
            return View();
        }

        public ActionResult GasInjectorDailyIndicatorDashboard()
        {
            return View();
        }

        public ActionResult EBOKGasProductionSummaryDashboard()
        {
            return View();
        }

        public ActionResult EBOKFieldProductionSummaryDashboard()
        {
            return View();
        }

        public ActionResult EBOKInjectivityIndexDashboard()
        {
            return View();
        }

        public ActionResult BackAllocationDashboard()
        {
            return View();
        }

    }
}
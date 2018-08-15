﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERAS.Models.EBOKOutputData
{
    public class BackAllocationQlinkSummary
    {
        public int Id { get; set; }
        public DateTime IndicatorDate { get; set; }
        public string FaultBlock { get; set; }
        public string RSV { get; set; }
        public double ProdOil { get; set; }
        public double TotalQlink { get; set; }

    }
}
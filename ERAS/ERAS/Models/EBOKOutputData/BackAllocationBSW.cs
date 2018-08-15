﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERAS.Models.EBOKOutputData
{
    public class BackAllocationBSW
    {
        public int Id { get; set; }
        public DateTime IndicatorDate { get; set; }
        public string Well { get; set; }
        public double BSW { get; set; }

    }
}
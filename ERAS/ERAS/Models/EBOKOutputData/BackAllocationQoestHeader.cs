using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERAS.Models.EBOKOutputData
{
    public class BackAllocationQoestHeader
    {
        public int Id { get; set; }
        public DateTime IndicatorDate { get; set; }
        public double ProdOil { get; set; }
        public double wellTestPotential { get; set; }
        public double WellTestActual { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERAS.Models.MasterData
{
    public class WellMasterData
    {
        public int Id { get; set; }
        public string WellCode { get; set; }
        public string WellName { get; set; }
        public string WellDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
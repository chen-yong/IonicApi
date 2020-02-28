using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeDrawPlotShared
    {
        public int Dpid { get; set; }
        public int UserId { get; set; }
        public string Permission { get; set; }

        public virtual PeDrawPlot Dp { get; set; }
        public virtual PeUser User { get; set; }
    }
}

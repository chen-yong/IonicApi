using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeDrawPlotOfBundle
    {
        public PeDrawPlotOfBundle()
        {
            PeDrawPlotOfBundleItem = new HashSet<PeDrawPlotOfBundleItem>();
        }

        public int Id { get; set; }

        public virtual PeDrawPlot IdNavigation { get; set; }
        public virtual ICollection<PeDrawPlotOfBundleItem> PeDrawPlotOfBundleItem { get; set; }
    }
}

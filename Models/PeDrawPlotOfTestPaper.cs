using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeDrawPlotOfTestPaper
    {
        public PeDrawPlotOfTestPaper()
        {
            PeDrawPlotOfTestPaperItem = new HashSet<PeDrawPlotOfTestPaperItem>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public virtual PeDrawPlot IdNavigation { get; set; }
        public virtual ICollection<PeDrawPlotOfTestPaperItem> PeDrawPlotOfTestPaperItem { get; set; }
    }
}

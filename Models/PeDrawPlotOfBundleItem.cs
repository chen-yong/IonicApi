using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeDrawPlotOfBundleItem
    {
        public int Id { get; set; }
        public int DrawPlotId { get; set; }
        public int LabId { get; set; }
        public int TopicId { get; set; }
        public int BundleRank { get; set; }
        public bool QuestionRandomRank { get; set; }

        public virtual PeDrawPlotOfBundle DrawPlot { get; set; }
        public virtual PeLab Lab { get; set; }
        public virtual PeTopic Topic { get; set; }
    }
}

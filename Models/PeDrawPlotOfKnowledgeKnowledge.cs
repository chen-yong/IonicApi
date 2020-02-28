using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeDrawPlotOfKnowledgeKnowledge
    {
        public int DrawPlotOfKownledgeId { get; set; }
        public int KownledgeId { get; set; }

        public virtual PeDrawPlotOfKnowledge DrawPlotOfKownledge { get; set; }
        public virtual PeKnowledge Kownledge { get; set; }
    }
}

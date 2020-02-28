using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeDrawPlotOfKnowledge
    {
        public PeDrawPlotOfKnowledge()
        {
            PeDrawPlotOfKnowledgeKnowledge = new HashSet<PeDrawPlotOfKnowledgeKnowledge>();
            PeDrawPlotOfKnowledgeQuestionDifficulty = new HashSet<PeDrawPlotOfKnowledgeQuestionDifficulty>();
            PeDrawPlotOfKnowledgeTopic = new HashSet<PeDrawPlotOfKnowledgeTopic>();
        }

        public int Id { get; set; }
        public int KownledgeBaseId { get; set; }

        public virtual PeDrawPlot IdNavigation { get; set; }
        public virtual PeKnowledgeBase KownledgeBase { get; set; }
        public virtual ICollection<PeDrawPlotOfKnowledgeKnowledge> PeDrawPlotOfKnowledgeKnowledge { get; set; }
        public virtual ICollection<PeDrawPlotOfKnowledgeQuestionDifficulty> PeDrawPlotOfKnowledgeQuestionDifficulty { get; set; }
        public virtual ICollection<PeDrawPlotOfKnowledgeTopic> PeDrawPlotOfKnowledgeTopic { get; set; }
    }
}

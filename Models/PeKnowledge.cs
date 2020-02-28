using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeKnowledge
    {
        public PeKnowledge()
        {
            PeDrawPlotOfKnowledgeKnowledge = new HashSet<PeDrawPlotOfKnowledgeKnowledge>();
            PeQuestionKnowledge = new HashSet<PeQuestionKnowledge>();
        }

        public int Id { get; set; }
        public int BaseId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public int? Ord { get; set; }
        public string Description { get; set; }
        public bool IsDel { get; set; }

        public virtual PeKnowledgeBase Base { get; set; }
        public virtual ICollection<PeDrawPlotOfKnowledgeKnowledge> PeDrawPlotOfKnowledgeKnowledge { get; set; }
        public virtual ICollection<PeQuestionKnowledge> PeQuestionKnowledge { get; set; }
    }
}

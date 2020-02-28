using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeKnowledgeBase
    {
        public PeKnowledgeBase()
        {
            PeDrawPlotOfKnowledge = new HashSet<PeDrawPlotOfKnowledge>();
            PeKnowledge = new HashSet<PeKnowledge>();
            PeKnowledgeBaseShared = new HashSet<PeKnowledgeBaseShared>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string KnowledgeBaseCode { get; set; }
        public string Description { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int Shared { get; set; }
        public bool IsDel { get; set; }

        public virtual PeUser CreateUser { get; set; }
        public virtual ICollection<PeDrawPlotOfKnowledge> PeDrawPlotOfKnowledge { get; set; }
        public virtual ICollection<PeKnowledge> PeKnowledge { get; set; }
        public virtual ICollection<PeKnowledgeBaseShared> PeKnowledgeBaseShared { get; set; }
    }
}

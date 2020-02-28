using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeKnowledgeBaseShared
    {
        public int KbId { get; set; }
        public int UserId { get; set; }
        public string Permission { get; set; }

        public virtual PeKnowledgeBase Kb { get; set; }
        public virtual PeUser User { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeQuestionKnowledge
    {
        public int QuestionId { get; set; }
        public int TopKnowledgeId { get; set; }
        public int KnowledgeId { get; set; }
        public double? Weight { get; set; }
        public string KnowledgeCode { get; set; }

        public virtual PeKnowledge Knowledge { get; set; }
        public virtual PeQuestion Question { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeQuestionDifficulty
    {
        public PeQuestionDifficulty()
        {
            PeDrawPlotOfKnowledgeQuestionDifficulty = new HashSet<PeDrawPlotOfKnowledgeQuestionDifficulty>();
            PeQuestion = new HashSet<PeQuestion>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PeDrawPlotOfKnowledgeQuestionDifficulty> PeDrawPlotOfKnowledgeQuestionDifficulty { get; set; }
        public virtual ICollection<PeQuestion> PeQuestion { get; set; }
    }
}

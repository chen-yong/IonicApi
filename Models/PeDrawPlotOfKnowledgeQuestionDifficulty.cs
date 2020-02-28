using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeDrawPlotOfKnowledgeQuestionDifficulty
    {
        public int DrawPlotOfKownledgeId { get; set; }
        public int QuestionDifficultyId { get; set; }
        public int Percentage { get; set; }

        public virtual PeDrawPlotOfKnowledge DrawPlotOfKownledge { get; set; }
        public virtual PeQuestionDifficulty QuestionDifficulty { get; set; }
    }
}

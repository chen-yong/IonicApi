using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeDrawPlotOfKnowledgeTopic
    {
        public int DrawPlotOfKownledgeId { get; set; }
        public int TopicId { get; set; }
        public int TotalQuestionCount { get; set; }
        public int QuestionCount { get; set; }
        public bool Checked { get; set; }
        public int? QuestionDifficultyCount1 { get; set; }
        public int? QuestionDifficultyCount2 { get; set; }
        public int? QuestionDifficultyCount3 { get; set; }
        public int? QuestionDifficultyCount4 { get; set; }
        public int? QuestionDifficultyCount5 { get; set; }

        public virtual PeDrawPlotOfKnowledge DrawPlotOfKownledge { get; set; }
        public virtual PeTopic Topic { get; set; }
    }
}

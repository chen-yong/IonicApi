using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeUserTestQuestionMutualJudgeItem
    {
        public int Id { get; set; }
        public int UserTestQuestionMutualJudgeId { get; set; }
        public int QuestionMutualJudgeRegulationId { get; set; }
        public int Score { get; set; }

        public virtual PeQuestionMutualJudgeRegulation QuestionMutualJudgeRegulation { get; set; }
        public virtual PeUserTestQuestionMutualJudge UserTestQuestionMutualJudge { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeUserTestQuestionJudgeItem
    {
        public int Id { get; set; }
        public int UserTestQuestionId { get; set; }
        public int QuestionMutualJudgeRegulationId { get; set; }
        public double Score { get; set; }

        public virtual PeQuestionMutualJudgeRegulation QuestionMutualJudgeRegulation { get; set; }
        public virtual PeUserTestQuestion UserTestQuestion { get; set; }
    }
}

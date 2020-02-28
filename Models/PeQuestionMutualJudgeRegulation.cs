using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeQuestionMutualJudgeRegulation
    {
        public PeQuestionMutualJudgeRegulation()
        {
            PeUserTestQuestionJudgeItem = new HashSet<PeUserTestQuestionJudgeItem>();
            PeUserTestQuestionMutualJudgeItem = new HashSet<PeUserTestQuestionMutualJudgeItem>();
        }

        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Name { get; set; }
        public string Contents { get; set; }
        public int Score { get; set; }
        public string Ord { get; set; }

        public virtual PeQuestion Question { get; set; }
        public virtual ICollection<PeUserTestQuestionJudgeItem> PeUserTestQuestionJudgeItem { get; set; }
        public virtual ICollection<PeUserTestQuestionMutualJudgeItem> PeUserTestQuestionMutualJudgeItem { get; set; }
    }
}

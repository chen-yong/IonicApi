using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeUserTestQuestion
    {
        public PeUserTestQuestion()
        {
            PeUserTestQuestionJudgeItem = new HashSet<PeUserTestQuestionJudgeItem>();
            PeUserTestQuestionMutualJudge = new HashSet<PeUserTestQuestionMutualJudge>();
        }

        public int Id { get; set; }
        public int UserTestId { get; set; }
        public int QuestionId { get; set; }
        public string Answer { get; set; }
        public string AnswerExt { get; set; }
        public double? TotoalScore { get; set; }
        public double? Score { get; set; }
        public string Comments { get; set; }
        public bool CanMutualJudge { get; set; }
        public string AnswerContentType { get; set; }
        public double? BestScore { get; set; }

        public virtual PeQuestion Question { get; set; }
        public virtual PeUserTest UserTest { get; set; }
        public virtual ICollection<PeUserTestQuestionJudgeItem> PeUserTestQuestionJudgeItem { get; set; }
        public virtual ICollection<PeUserTestQuestionMutualJudge> PeUserTestQuestionMutualJudge { get; set; }
    }
}

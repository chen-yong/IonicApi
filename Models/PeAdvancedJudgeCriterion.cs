using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeAdvancedJudgeCriterion
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string RegexPatten { get; set; }
        public double Score { get; set; }
        public string Memo { get; set; }

        public virtual PeQuestion Question { get; set; }
    }
}

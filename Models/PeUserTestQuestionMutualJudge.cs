using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeUserTestQuestionMutualJudge
    {
        public PeUserTestQuestionMutualJudge()
        {
            PeUserTestQuestionMutualJudgeItem = new HashSet<PeUserTestQuestionMutualJudgeItem>();
        }

        public int Id { get; set; }
        public int UserTestQuestionId { get; set; }
        public int AuthorStudentId { get; set; }
        public string 作业人 { get; set; }
        public int JudgeStudentId { get; set; }
        public string 评价人 { get; set; }
        public double Score { get; set; }
        public string Comments { get; set; }
        public bool IsAuthorVisible { get; set; }
        public DateTime TimeCreated { get; set; }

        public virtual PeUser AuthorStudent { get; set; }
        public virtual PeUser JudgeStudent { get; set; }
        public virtual PeUserTestQuestion UserTestQuestion { get; set; }
        public virtual ICollection<PeUserTestQuestionMutualJudgeItem> PeUserTestQuestionMutualJudgeItem { get; set; }
    }
}

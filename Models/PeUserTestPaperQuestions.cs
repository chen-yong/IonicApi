using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeUserTestPaperQuestions
    {
        public int Id { get; set; }
        public int TopicId { get; set; }
        public int QuestionId { get; set; }
        public int PaperId { get; set; }
        public int Rank { get; set; }
        public bool IsDel { get; set; }
        public string Ord { get; set; }

        public virtual PeUserTestPaper Paper { get; set; }
        public virtual PeQuestion Question { get; set; }
        public virtual PeUserTestPaperTopic Topic { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeUserTestPaperTopic
    {
        public PeUserTestPaperTopic()
        {
            PeUserTestPaperQuestions = new HashSet<PeUserTestPaperQuestions>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int PaperId { get; set; }
        public int TopicId { get; set; }
        public bool IsDel { get; set; }
        public string BasicTopicId { get; set; }
        public int? Ord { get; set; }

        public virtual PeUserTestPaper Paper { get; set; }
        public virtual PeTopic Topic { get; set; }
        public virtual ICollection<PeUserTestPaperQuestions> PeUserTestPaperQuestions { get; set; }
    }
}

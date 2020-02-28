using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeUserTestPaper
    {
        public PeUserTestPaper()
        {
            PeUserTestPaperQuestions = new HashSet<PeUserTestPaperQuestions>();
            PeUserTestPaperTopic = new HashSet<PeUserTestPaperTopic>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsDel { get; set; }
        public int DrawplotId { get; set; }

        public virtual PeUser CreateUser { get; set; }
        public virtual PeDrawPlot Drawplot { get; set; }
        public virtual ICollection<PeUserTestPaperQuestions> PeUserTestPaperQuestions { get; set; }
        public virtual ICollection<PeUserTestPaperTopic> PeUserTestPaperTopic { get; set; }
    }
}

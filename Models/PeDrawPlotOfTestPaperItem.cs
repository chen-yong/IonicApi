using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeDrawPlotOfTestPaperItem
    {
        public int Id { get; set; }
        public int DrawPlotOfTestPaperId { get; set; }
        public int TopicId { get; set; }
        public int QuestionId { get; set; }
        public int? OrdOfTopic { get; set; }
        public int? OrdOfQuestion { get; set; }

        public virtual PeDrawPlotOfTestPaper DrawPlotOfTestPaper { get; set; }
        public virtual PeQuestion Question { get; set; }
        public virtual PeTopic Topic { get; set; }
    }
}

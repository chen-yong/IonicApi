using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeBasicTopic
    {
        public PeBasicTopic()
        {
            PeLabCategoryBasicTopic = new HashSet<PeLabCategoryBasicTopic>();
            PeQuestionSubQuestion = new HashSet<PeQuestionSubQuestion>();
            PeTopic = new HashSet<PeTopic>();
        }

        public string Id { get; set; }
        public string Label { get; set; }
        public string Ord { get; set; }
        public string QuestionEditViewName { get; set; }
        public string QuestionExpoViewName { get; set; }
        public bool AutoJudge { get; set; }
        public string JudgeClassName { get; set; }
        public bool ManualJudge { get; set; }
        public string JudgeViewName { get; set; }
        public bool JudgeOnSave { get; set; }
        public string AnswerContentType { get; set; }

        public virtual ICollection<PeLabCategoryBasicTopic> PeLabCategoryBasicTopic { get; set; }
        public virtual ICollection<PeQuestionSubQuestion> PeQuestionSubQuestion { get; set; }
        public virtual ICollection<PeTopic> PeTopic { get; set; }
    }
}

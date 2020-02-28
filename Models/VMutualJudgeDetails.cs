using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class VMutualJudgeDetails
    {
        public int JudgeStudentId { get; set; }
        public string JudgeStudenName { get; set; }
        public int UserTestId { get; set; }
        public string UserTestUserName { get; set; }
        public int QuestionId { get; set; }
        public string QuestionFace { get; set; }
        public string Answer { get; set; }
        public string AnswerExt { get; set; }
        public double? UserTestQuestionMutualJudgeScore { get; set; }
        public string Comments { get; set; }
        public bool? IsAuthorVisible { get; set; }
        public int QuestionMutualJudgeRegulationId { get; set; }
        public string Contents { get; set; }
        public int QuestionMutualJudgeRegulationScore { get; set; }
        public int? UserTestQuestionMutualJudgeItemScore { get; set; }
    }
}

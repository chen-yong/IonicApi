using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeQuestionSubQuestion
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string BasicTopicId { get; set; }
        public string QuestionFace { get; set; }
        public double Score { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string OptionE { get; set; }
        public string OptionF { get; set; }
        public string OptionG { get; set; }
        public string OptionH { get; set; }
        public string OptionI { get; set; }
        public string OptionJ { get; set; }
        public string Blank1 { get; set; }
        public string Blank2 { get; set; }
        public string Blank3 { get; set; }
        public string Blank4 { get; set; }
        public string Blank5 { get; set; }
        public string Blank6 { get; set; }
        public string Blank7 { get; set; }
        public string Blank8 { get; set; }
        public string Blank9 { get; set; }
        public string Blank10 { get; set; }
        public int? DesignAnswerMode { get; set; }
        public string AnswerKey { get; set; }
        public string AnswerKeyExt { get; set; }
        public string DefaultAnswer { get; set; }
        public int? Ord { get; set; }
        public string Property00 { get; set; }
        public string Property01 { get; set; }
        public string Property02 { get; set; }
        public string Property03 { get; set; }
        public string Property04 { get; set; }
        public bool? FillBlankAnswerOrderCasually { get; set; }

        public virtual PeBasicTopic BasicTopic { get; set; }
        public virtual PeQuestion Question { get; set; }
    }
}

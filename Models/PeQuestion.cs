using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeQuestion
    {
        public PeQuestion()
        {
            PeAdvancedJudgeCriterion = new HashSet<PeAdvancedJudgeCriterion>();
            PeDrawPlotOfTestPaperItem = new HashSet<PeDrawPlotOfTestPaperItem>();
            PeQuestionKnowledge = new HashSet<PeQuestionKnowledge>();
            PeQuestionMaterials = new HashSet<PeQuestionMaterials>();
            PeQuestionMutualJudgeRegulation = new HashSet<PeQuestionMutualJudgeRegulation>();
            PeQuestionSubQuestion = new HashSet<PeQuestionSubQuestion>();
            PeUserTestPaperQuestions = new HashSet<PeUserTestPaperQuestions>();
            PeUserTestQuestion = new HashSet<PeUserTestQuestion>();
        }

        public int Id { get; set; }
        public string Nid { get; set; }
        public int LabId { get; set; }
        public int TopicId { get; set; }
        public int BundleRank { get; set; }
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
        public int Status { get; set; }
        public string DefaultAnswer { get; set; }
        public int? Difficulty { get; set; }
        public string Knowledge { get; set; }
        public string Analysis { get; set; }
        public int? Ord { get; set; }
        public string DifferentiationDegree { get; set; }
        public bool? FillBlankAnswerOrderCasually { get; set; }
        public bool IsDel { get; set; }
        public string Property00 { get; set; }
        public string Property01 { get; set; }
        public string Property02 { get; set; }
        public string Property03 { get; set; }
        public string Property04 { get; set; }
        public int? MaxTopKnowledgeId { get; set; }
        public bool CanMutualJudge { get; set; }
        public string AnswerContentType { get; set; }
        public string JudgeReferDir { get; set; }

        public virtual PeQuestionDifficulty DifficultyNavigation { get; set; }
        public virtual PeLab Lab { get; set; }
        public virtual PeTopic Topic { get; set; }
        public virtual PeQuestionDesign PeQuestionDesign { get; set; }
        public virtual ICollection<PeAdvancedJudgeCriterion> PeAdvancedJudgeCriterion { get; set; }
        public virtual ICollection<PeDrawPlotOfTestPaperItem> PeDrawPlotOfTestPaperItem { get; set; }
        public virtual ICollection<PeQuestionKnowledge> PeQuestionKnowledge { get; set; }
        public virtual ICollection<PeQuestionMaterials> PeQuestionMaterials { get; set; }
        public virtual ICollection<PeQuestionMutualJudgeRegulation> PeQuestionMutualJudgeRegulation { get; set; }
        public virtual ICollection<PeQuestionSubQuestion> PeQuestionSubQuestion { get; set; }
        public virtual ICollection<PeUserTestPaperQuestions> PeUserTestPaperQuestions { get; set; }
        public virtual ICollection<PeUserTestQuestion> PeUserTestQuestion { get; set; }
    }
}

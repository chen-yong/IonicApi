using IonicApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Dtos
{
    public class QuestionDto
    {
        public QuestionDto()
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
        /// <summary>
        /// 策略id
        /// </summary>
        public int LabId { get; set; }
        /// <summary>
        /// 题型
        /// </summary>
        public int TopicId { get; set; }
        /// <summary>
        /// 题号
        /// </summary>
        public int BundleRank { get; set; }
        /// <summary>
        /// 题目
        /// </summary>
        public string QuestionFace { get; set; }
        /// <summary>
        /// 分数
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// 选项A
        /// </summary>
        public string OptionA { get; set; }
        /// <summary>
        /// 选项B
        /// </summary>
        public string OptionB { get; set; }
        /// <summary>
        /// 选项C
        /// </summary>
        public string OptionC { get; set; }
        /// <summary>
        /// 选项D
        /// </summary>
        public string OptionD { get; set; }
        /// <summary>
        /// 正确答案
        /// </summary>
        public string AnswerKey { get; set; }
        /// <summary>
        /// 答案解释
        /// </summary>
        public string AnswerKeyExt { get; set; }
        //public int Status { get; set; }
        /// <summary>
        /// 默认答案
        /// </summary>
        public string DefaultAnswer { get; set; }
        /// <summary>
        /// 难度：1：简单 2：较简单 3：中等 4：较难 5：难
        /// </summary>
        public int? Difficulty { get; set; }
        /// <summary>
        /// 全部知识点
        /// </summary>
        public string Knowledge { get; set; }
        /// <summary>
        /// 题序
        /// </summary>
        public int? Ord { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDel { get; set; }
        /// <summary>
        /// 子级知识点
        /// </summary>
        public int? MaxTopKnowledgeId { get; set; }
      
    }
}

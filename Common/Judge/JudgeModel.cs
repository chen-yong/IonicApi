using IonicApi.Dtos;
using IonicApi.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IonicApi.Common.Judge
{
    public class JudgeModel
    {
        public PeTest Test { get; set; }
        public PeCourse Course { get; set; }
        public IList<JudgeOneModel> Members { get; set; }
    }
    public class JudgeOneModel
    {
        public JudgeOneModel()
        {
            TopicScore = new List<SelectListItem>();
            QuestionJudgeResultSet = new List<JudgeResult>();
        }
        public int FinishQuestionCount { get; set; }
        public int Id { get; set; }
        public string UserTestNo { get; set; }
        public string UserTrueName { get; set; }
        public string ClassName { get; set; }
        public string LogonIP { get; set; }
        public DateTime? LogonTime { get; set; }
        public DateTime? SubmitTime { get; set; }
        public double TotalScore { get; set; }
        public double Score { get; set; }
        public bool Status { get; set; }
        //public List<int> TopicIdList { get; set; } 
        //public List<double?> TopicScore { get; set; }
        public List<SelectListItem> TopicScore { get; set; }
        public List<JudgeResult> QuestionJudgeResultSet { get; set; }
        public string JudgeReport
        {
            get
            {
                return string.Join("\r\n", QuestionJudgeResultSet.OrderBy(e => e.TopicId).ThenBy(e => e.Ord).ToList().ConvertAll<string>(e => e.Report));
            }
        }
        public string JudgeReportDB { get; set; }
        public bool ShouldManualJudge { get; set; }
        public bool IsDelaySubmit { get; set; }
    }
}

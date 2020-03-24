using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Dtos
{
    public class TestDto
    {
        public int Id { get; set; }
        public string Nid { get; set; }
        public string Name { get; set; }
        public int Mode { get; set; }
        public bool IsOpen { get; set; }
        public int TimeLimit { get; set; }
        public int RetryTimes { get; set; }
        public string Memo { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsDel { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? RestTime { get; set; }
        public int? LunchTime { get; set; }
        public bool? ForbiddenCopy { get; set; }
        public bool? ForbiddenMouseRightMenu { get; set; }
        public bool? EnableClientJudge { get; set; }
        public bool? KeyVisible { get; set; }
        public bool? AutoSubmitOnTimeLimit { get; set; }
        public int? DrawPlotId { get; set; }
        public int? TestTemplateId { get; set; }
        public int? CourseId { get; set; }
        public bool? EnableMutualJudge { get; set; }
        public DateTime? MutualJudgeEndTime { get; set; }
        public bool? IsMutualJudgeGroupingPublished { get; set; }
        public DateTime? TimeMutualJudgeGroupingPublish { get; set; }
        public int? MutualJudgeGroupingSize { get; set; }
        public double? SetScore { get; set; }
        public bool ViewOneWithAnswerKey { get; set; }
        public int? Ord { get; set; }
        public int? ScoreAppear { get; set; }
        public DateTime? DelayEndTime { get; set; }
        public double? DelayPercentOfScore { get; set; }
        public bool IpallowAccessCheck { get; set; }
    }
}

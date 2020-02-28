using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeTest
    {
        public PeTest()
        {
            PePaperOutputTask = new HashSet<PePaperOutputTask>();
            PeTestInvigilator = new HashSet<PeTestInvigilator>();
            PeTestIpplot = new HashSet<PeTestIpplot>();
            PeTestJudgePro = new HashSet<PeTestJudgePro>();
            PeTestMutualJudgeGroup = new HashSet<PeTestMutualJudgeGroup>();
            PeTestRoomUse = new HashSet<PeTestRoomUse>();
            PeTestSession = new HashSet<PeTestSession>();
            PeUserTest = new HashSet<PeUserTest>();
        }

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

        public virtual PeCourse Course { get; set; }
        public virtual PeUser CreateUser { get; set; }
        public virtual PeDrawPlot DrawPlot { get; set; }
        public virtual PeTemplate TestTemplate { get; set; }
        public virtual ICollection<PePaperOutputTask> PePaperOutputTask { get; set; }
        public virtual ICollection<PeTestInvigilator> PeTestInvigilator { get; set; }
        public virtual ICollection<PeTestIpplot> PeTestIpplot { get; set; }
        public virtual ICollection<PeTestJudgePro> PeTestJudgePro { get; set; }
        public virtual ICollection<PeTestMutualJudgeGroup> PeTestMutualJudgeGroup { get; set; }
        public virtual ICollection<PeTestRoomUse> PeTestRoomUse { get; set; }
        public virtual ICollection<PeTestSession> PeTestSession { get; set; }
        public virtual ICollection<PeUserTest> PeUserTest { get; set; }
    }
}

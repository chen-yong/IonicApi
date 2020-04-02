using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Dtos
{
    public class UserTestDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserTrueName { get; set; }
        public string UserTestNo { get; set; }
        public int TestId { get; set; }
        public int? TestSessionId { get; set; }
        public int? TestRoomId { get; set; }
        public DateTime? LogonTime { get; set; }
        public string LogonIp { get; set; }
        public string SessionId { get; set; }
        public DateTime? SubmitTime { get; set; }
        public double? TotalScore { get; set; }
        public double? Score { get; set; }
        public bool? Status { get; set; }
        public string ClassName { get; set; }
        public int? SlideSec { get; set; }
        public double? ScoreAlter { get; set; }
        public bool IsForbid { get; set; }
        public string JudgeReport { get; set; }
        public string Property00 { get; set; }
        public string Property01 { get; set; }
        public string Property02 { get; set; }
        public string Property03 { get; set; }
        public string Property04 { get; set; }
        public string Property05 { get; set; }
        public string Property06 { get; set; }
        public string Property07 { get; set; }
        public string Property08 { get; set; }
        public string Property09 { get; set; }
        public DateTime? DrawTime { get; set; }
        public int? ParentId { get; set; }
        public string UserTestType { get; set; }
        public int QuestionCount { get; set; }
        public int MutualJudgeQuestionCount { get; set; }
        public bool? IsSubmitDelay { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class VUserTest
    {
        public int TestId { get; set; }
        public string 校区 { get; set; }
        public string 学院 { get; set; }
        public string 任课老师 { get; set; }
        public string 考试时间 { get; set; }
        public string 场次名称 { get; set; }
        public string 考试地点 { get; set; }
        public string 座位号 { get; set; }
        public string RoomAddrId { get; set; }
        public string RoomAddr { get; set; }
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserTrueName { get; set; }
        public string UserTestNo { get; set; }
        public string UserName { get; set; }
        public DateTime? Birthday { get; set; }
        public string Sex { get; set; }
        public int? TestSessionId { get; set; }
        public int? TestRoomId { get; set; }
        public DateTime? LogonTime { get; set; }
        public string LogonIp { get; set; }
        public string SessionId { get; set; }
        public DateTime? SubmitTime { get; set; }
        public double? SetScore { get; set; }
        public double? TotalScore { get; set; }
        public double? Score { get; set; }
        public bool? Status { get; set; }
        public string ClassName { get; set; }
        public int? SlideSec { get; set; }
        public double? ScoreAlter { get; set; }
        public bool IsForbid { get; set; }
        public string 阅卷时间 { get; set; }
        public DateTime? DrawTime { get; set; }
        public int QuestionCount { get; set; }
        public int MutualJudgeQuestionCount { get; set; }
        public int? 答题数 { get; set; }
    }
}

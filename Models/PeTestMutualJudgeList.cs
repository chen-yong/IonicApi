using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeTestMutualJudgeList
    {
        public int Id { get; set; }
        public int TestId { get; set; }
        public int? GroupId { get; set; }
        public string GroupName { get; set; }
        public int JudgeStudentId { get; set; }
        public string JudgeStudenName { get; set; }
        public int UserTestId { get; set; }
        public string UserTestUserName { get; set; }
        public double? Score { get; set; }
        public DateTime? TimeJudged { get; set; }

        public virtual PeUser JudgeStudent { get; set; }
        public virtual PeUserTest UserTest { get; set; }
    }
}

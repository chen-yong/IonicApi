using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeTestJudgeProItem
    {
        public int Id { get; set; }
        public int TestId { get; set; }
        public int UserId { get; set; }
        public int UserTestId { get; set; }
        public string TopicIdList { get; set; }
    }
}

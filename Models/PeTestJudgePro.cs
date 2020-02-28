using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeTestJudgePro
    {
        public int Id { get; set; }
        public int TestId { get; set; }
        public int UserId { get; set; }
        public int TopicId { get; set; }

        public virtual PeTest Test { get; set; }
        public virtual PeUser User { get; set; }
    }
}

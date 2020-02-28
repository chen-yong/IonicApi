using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeTestInvigilator
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int TestId { get; set; }
        public int? TestSessionId { get; set; }
        public int TestRoomId { get; set; }
        public string TestRoomName { get; set; }
        public string TimePeriod { get; set; }

        public virtual PeUser Teacher { get; set; }
        public virtual PeTest Test { get; set; }
        public virtual PeTestRoom TestRoom { get; set; }
        public virtual PeTestSession TestSession { get; set; }
    }
}

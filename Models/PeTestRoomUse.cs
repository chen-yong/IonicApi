using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeTestRoomUse
    {
        public int TestId { get; set; }
        public int TestRoomId { get; set; }

        public virtual PeTest Test { get; set; }
        public virtual PeTestRoom TestRoom { get; set; }
    }
}

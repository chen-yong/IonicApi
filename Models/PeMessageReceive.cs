using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeMessageReceive
    {
        public int MessageId { get; set; }
        public int Receiver { get; set; }
        public bool IsReaded { get; set; }
        public bool IsDel { get; set; }
        public bool IsRecycle { get; set; }

        public virtual PeMessage Message { get; set; }
        public virtual PeUser ReceiverNavigation { get; set; }
    }
}

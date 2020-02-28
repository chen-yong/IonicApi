using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeMessage
    {
        public PeMessage()
        {
            PeMessageAttach = new HashSet<PeMessageAttach>();
            PeMessageReceive = new HashSet<PeMessageReceive>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public int Sender { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsImportant { get; set; }
        public DateTime SendTime { get; set; }
        public bool IsDel { get; set; }
        public bool IsRecycle { get; set; }

        public virtual PeUser SenderNavigation { get; set; }
        public virtual ICollection<PeMessageAttach> PeMessageAttach { get; set; }
        public virtual ICollection<PeMessageReceive> PeMessageReceive { get; set; }
    }
}

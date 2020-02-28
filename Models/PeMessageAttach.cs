using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeMessageAttach
    {
        public int Id { get; set; }
        public int MessageId { get; set; }
        public string Icon { get; set; }
        public string FileName { get; set; }
        public string Url { get; set; }
        public decimal Size { get; set; }

        public virtual PeMessage Message { get; set; }
    }
}

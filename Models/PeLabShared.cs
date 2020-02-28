using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeLabShared
    {
        public int LabId { get; set; }
        public int UserId { get; set; }
        public string Permission { get; set; }

        public virtual PeLab Lab { get; set; }
        public virtual PeUser User { get; set; }
    }
}

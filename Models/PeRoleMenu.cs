using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeRoleMenu
    {
        public int Id { get; set; }
        public int RoldId { get; set; }
        public int MenuId { get; set; }
        public bool IsOpen { get; set; }

        public virtual PeMenu Menu { get; set; }
        public virtual PeRole Rold { get; set; }
    }
}

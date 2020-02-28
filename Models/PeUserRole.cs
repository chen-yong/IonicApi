using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeUserRole
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public virtual PeRole Role { get; set; }
        public virtual PeUser User { get; set; }
    }
}

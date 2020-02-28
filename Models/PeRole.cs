using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeRole
    {
        public PeRole()
        {
            PeRoleMenu = new HashSet<PeRoleMenu>();
            PeUserRole = new HashSet<PeUserRole>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? ReadOnly { get; set; }
        public int? Ord { get; set; }

        public virtual ICollection<PeRoleMenu> PeRoleMenu { get; set; }
        public virtual ICollection<PeUserRole> PeUserRole { get; set; }
    }
}

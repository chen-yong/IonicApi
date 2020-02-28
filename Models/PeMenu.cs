using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeMenu
    {
        public PeMenu()
        {
            PeRoleMenu = new HashSet<PeRoleMenu>();
        }

        public int Id { get; set; }
        public string Group { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public int? Ord { get; set; }
        public string Icon01 { get; set; }
        public string Icon02 { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public bool IsValid { get; set; }

        public virtual ICollection<PeRoleMenu> PeRoleMenu { get; set; }
    }
}

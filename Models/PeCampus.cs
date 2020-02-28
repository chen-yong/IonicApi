using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeCampus
    {
        public PeCampus()
        {
            PeTestRoom = new HashSet<PeTestRoom>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        public string SchoolId { get; set; }

        public virtual ICollection<PeTestRoom> PeTestRoom { get; set; }
    }
}

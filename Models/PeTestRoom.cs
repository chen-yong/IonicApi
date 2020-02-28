using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeTestRoom
    {
        public PeTestRoom()
        {
            PeTestInvigilator = new HashSet<PeTestInvigilator>();
            PeTestRoomUse = new HashSet<PeTestRoomUse>();
            PeUserTest = new HashSet<PeUserTest>();
        }

        public int Id { get; set; }
        public string Address { get; set; }
        public int? UsefulComputer { get; set; }
        public int? PrepComputer { get; set; }
        public string Description { get; set; }
        public string Property00 { get; set; }
        public string Property01 { get; set; }
        public string Property02 { get; set; }
        public string Property03 { get; set; }
        public string Property04 { get; set; }
        public int? CampusId { get; set; }
        public string SchoolId { get; set; }

        public virtual PeCampus Campus { get; set; }
        public virtual ICollection<PeTestInvigilator> PeTestInvigilator { get; set; }
        public virtual ICollection<PeTestRoomUse> PeTestRoomUse { get; set; }
        public virtual ICollection<PeUserTest> PeUserTest { get; set; }
    }
}

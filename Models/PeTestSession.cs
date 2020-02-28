using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeTestSession
    {
        public PeTestSession()
        {
            PeTestInvigilator = new HashSet<PeTestInvigilator>();
            PeUserTest = new HashSet<PeUserTest>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? StudentCount { get; set; }
        public int? TestId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Description { get; set; }

        public virtual PeTest Test { get; set; }
        public virtual ICollection<PeTestInvigilator> PeTestInvigilator { get; set; }
        public virtual ICollection<PeUserTest> PeUserTest { get; set; }
    }
}

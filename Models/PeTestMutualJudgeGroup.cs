using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeTestMutualJudgeGroup
    {
        public PeTestMutualJudgeGroup()
        {
            PeTestMutualJudgeGroupItem = new HashSet<PeTestMutualJudgeGroupItem>();
        }

        public int Id { get; set; }
        public int TestId { get; set; }
        public string Name { get; set; }

        public virtual PeTest Test { get; set; }
        public virtual ICollection<PeTestMutualJudgeGroupItem> PeTestMutualJudgeGroupItem { get; set; }
    }
}

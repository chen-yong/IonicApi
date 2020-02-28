using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeTestMutualJudgeGroupItem
    {
        public int MutualJudgeGroupId { get; set; }
        public int UserTestId { get; set; }

        public virtual PeTestMutualJudgeGroup MutualJudgeGroup { get; set; }
        public virtual PeUserTest UserTest { get; set; }
    }
}

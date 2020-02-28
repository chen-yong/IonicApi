using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeLabCategoryBasicTopic
    {
        public int LabCategoryId { get; set; }
        public string BasicTopicId { get; set; }

        public virtual PeBasicTopic BasicTopic { get; set; }
        public virtual PeLabCategory LabCategory { get; set; }
    }
}

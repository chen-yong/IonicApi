using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeTopicBundleLabelText
    {
        public int Id { get; set; }
        public int TopicId { get; set; }
        public int BundleRank { get; set; }
        public string LabelText { get; set; }
        public int? BundleOrder { get; set; }

        public virtual PeTopic Topic { get; set; }
    }
}

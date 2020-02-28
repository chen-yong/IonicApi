using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeTopic
    {
        public PeTopic()
        {
            PeDrawPlotOfBundleItem = new HashSet<PeDrawPlotOfBundleItem>();
            PeDrawPlotOfKnowledgeTopic = new HashSet<PeDrawPlotOfKnowledgeTopic>();
            PeDrawPlotOfTestPaperItem = new HashSet<PeDrawPlotOfTestPaperItem>();
            PeQuestion = new HashSet<PeQuestion>();
            PeTopicBundleLabelText = new HashSet<PeTopicBundleLabelText>();
            PeUserTestPaperTopic = new HashSet<PeUserTestPaperTopic>();
        }

        public int Id { get; set; }
        public int LabId { get; set; }
        public string Nid { get; set; }
        public string BasicTopicId { get; set; }
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Memo { get; set; }
        public bool IsDel { get; set; }
        public string Ord { get; set; }
        public string WorkDirName { get; set; }
        public string ProcessDetection { get; set; }

        public virtual PeBasicTopic BasicTopic { get; set; }
        public virtual PeLab Lab { get; set; }
        public virtual ICollection<PeDrawPlotOfBundleItem> PeDrawPlotOfBundleItem { get; set; }
        public virtual ICollection<PeDrawPlotOfKnowledgeTopic> PeDrawPlotOfKnowledgeTopic { get; set; }
        public virtual ICollection<PeDrawPlotOfTestPaperItem> PeDrawPlotOfTestPaperItem { get; set; }
        public virtual ICollection<PeQuestion> PeQuestion { get; set; }
        public virtual ICollection<PeTopicBundleLabelText> PeTopicBundleLabelText { get; set; }
        public virtual ICollection<PeUserTestPaperTopic> PeUserTestPaperTopic { get; set; }
    }
}

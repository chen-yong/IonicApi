using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeLab
    {
        public PeLab()
        {
            PeDrawPlot = new HashSet<PeDrawPlot>();
            PeDrawPlotOfBundleItem = new HashSet<PeDrawPlotOfBundleItem>();
            PeLabShared = new HashSet<PeLabShared>();
            PeQuestion = new HashSet<PeQuestion>();
            PeTopic = new HashSet<PeTopic>();
        }

        public int Id { get; set; }
        public string LabCode { get; set; }
        public int? KownledgeBaseId { get; set; }
        public string Name { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public int Status { get; set; }
        public int Shared { get; set; }
        public int? Compiler { get; set; }
        public int? LabCategoryId { get; set; }
        public string Ord { get; set; }
        public string KownledgeBaseName { get; set; }
        public string OriginalLabFile { get; set; }

        public virtual PeCompiler CompilerNavigation { get; set; }
        public virtual PeUser CreateUser { get; set; }
        public virtual PeLabCategory LabCategory { get; set; }
        public virtual ICollection<PeDrawPlot> PeDrawPlot { get; set; }
        public virtual ICollection<PeDrawPlotOfBundleItem> PeDrawPlotOfBundleItem { get; set; }
        public virtual ICollection<PeLabShared> PeLabShared { get; set; }
        public virtual ICollection<PeQuestion> PeQuestion { get; set; }
        public virtual ICollection<PeTopic> PeTopic { get; set; }
    }
}

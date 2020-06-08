using IonicApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Dtos
{
    public class PeDrawPlotDto
    {
        public int Id { get; set; }
        public int LabId { get; set; }
        public string Dptype { get; set; }
        public string Name { get; set; }
        public string Memo { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public int Shared { get; set; }
        public bool IsDel { get; set; }
        public bool QuestionRandom { get; set; }
        public string SettingObject { get; set; }
        public int? CataId { get; set; }
        public int? Ord { get; set; }
        public string DiffPaperCount { get; set; }

        public virtual PeDrawPlotCata Cata { get; set; }
        public virtual PeLab Lab { get; set; }
        public virtual PeDrawPlotOfBundle PeDrawPlotOfBundle { get; set; }
        public virtual PeDrawPlotOfKnowledge PeDrawPlotOfKnowledge { get; set; }
        public virtual PeDrawPlotOfTestPaper PeDrawPlotOfTestPaper { get; set; }
        public virtual ICollection<PeDrawPlotShared> PeDrawPlotShared { get; set; }
        public virtual ICollection<PeTest> PeTest { get; set; }
        public virtual ICollection<PeUserTestPaper> PeUserTestPaper { get; set; }
    }
}

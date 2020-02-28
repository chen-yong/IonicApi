using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeDrawPlotCata
    {
        public PeDrawPlotCata()
        {
            PeDrawPlot = new HashSet<PeDrawPlot>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public int Ord { get; set; }
        public bool? IsDel { get; set; }
        public string DbType { get; set; }

        public virtual ICollection<PeDrawPlot> PeDrawPlot { get; set; }
    }
}

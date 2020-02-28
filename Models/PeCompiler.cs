using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeCompiler
    {
        public PeCompiler()
        {
            PeLab = new HashSet<PeLab>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string ExePath { get; set; }
        public string Arguments { get; set; }
        public string Property00 { get; set; }
        public string Property01 { get; set; }
        public string Property02 { get; set; }
        public string Property03 { get; set; }
        public string Property04 { get; set; }
        public string Property05 { get; set; }

        public virtual ICollection<PeLab> PeLab { get; set; }
    }
}

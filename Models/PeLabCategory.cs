using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeLabCategory
    {
        public PeLabCategory()
        {
            PeLab = new HashSet<PeLab>();
            PeLabCategoryBasicTopic = new HashSet<PeLabCategoryBasicTopic>();
        }

        public int Id { get; set; }
        public string TypeName { get; set; }
        public bool CanCompile { get; set; }

        public virtual ICollection<PeLab> PeLab { get; set; }
        public virtual ICollection<PeLabCategoryBasicTopic> PeLabCategoryBasicTopic { get; set; }
    }
}

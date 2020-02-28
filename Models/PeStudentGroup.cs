using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeStudentGroup
    {
        public PeStudentGroup()
        {
            PeStudentGroupItem = new HashSet<PeStudentGroupItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Property00 { get; set; }
        public string Property01 { get; set; }
        public string Property02 { get; set; }
        public string Property03 { get; set; }
        public string Property04 { get; set; }
        public string Property05 { get; set; }
        public string Property06 { get; set; }
        public string Property07 { get; set; }
        public string Property08 { get; set; }
        public string Property09 { get; set; }

        public virtual PeUser CreateUser { get; set; }
        public virtual ICollection<PeStudentGroupItem> PeStudentGroupItem { get; set; }
    }
}

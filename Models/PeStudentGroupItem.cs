using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeStudentGroupItem
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int GroupId { get; set; }
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

        public virtual PeStudentGroup Group { get; set; }
        public virtual PeUser User { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeSysNotice
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SysContent { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? CreateUserId { get; set; }
        public int? Type { get; set; }
        public int? CourseId { get; set; }
        public bool IsSettop { get; set; }

        public virtual PeUser CreateUser { get; set; }
    }
}

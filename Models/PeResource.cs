using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeResource
    {
        public PeResource()
        {
            PeCourseResource = new HashSet<PeCourseResource>();
        }

        public int Id { get; set; }
        public int ParentId { get; set; }
        public string FileName { get; set; }
        public string FileIcon { get; set; }
        public string Url { get; set; }
        public string FileType { get; set; }
        public double Size { get; set; }
        public bool IsDir { get; set; }
        public bool IsDel { get; set; }
        public bool IsShared { get; set; }
        public DateTime CreateTime { get; set; }
        public int UserId { get; set; }
        public string Password { get; set; }

        public virtual ICollection<PeCourseResource> PeCourseResource { get; set; }
    }
}

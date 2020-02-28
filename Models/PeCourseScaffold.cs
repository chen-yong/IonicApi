using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeCourseScaffold
    {
        public PeCourseScaffold()
        {
            PeCourseware = new HashSet<PeCourseware>();
        }

        public string Id { get; set; }
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ParentId { get; set; }
        public string IdPath { get; set; }
        public int Depth { get; set; }
        public int? Orderby { get; set; }
        public bool IsDel { get; set; }

        public virtual PeCourse Course { get; set; }
        public virtual ICollection<PeCourseware> PeCourseware { get; set; }
    }
}

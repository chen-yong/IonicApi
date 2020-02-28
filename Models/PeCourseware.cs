using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeCourseware
    {
        public string Id { get; set; }
        public int CourseId { get; set; }
        public string ScaffoldId { get; set; }
        public string CoursewareType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateUpdate { get; set; }
        public int Orderby { get; set; }
        public bool IsDel { get; set; }
        public string Metadata { get; set; }

        public virtual PeCourse Course { get; set; }
        public virtual PeCourseScaffold Scaffold { get; set; }
    }
}

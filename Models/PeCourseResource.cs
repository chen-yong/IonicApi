using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeCourseResource
    {
        public int CourseId { get; set; }
        public int ResourceId { get; set; }

        public virtual PeCourse Course { get; set; }
        public virtual PeResource Resource { get; set; }
    }
}

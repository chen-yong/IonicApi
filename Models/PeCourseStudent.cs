using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeCourseStudent
    {
        public int CourseId { get; set; }
        public int UserId { get; set; }
        public double Zycj { get; set; }
        public double Sycj { get; set; }
        public double Kscj1 { get; set; }
        public double Kscj2 { get; set; }
        public double Kscj3 { get; set; }
        public double Kscj4 { get; set; }
        public double Kscj5 { get; set; }
        public double Cj { get; set; }

        public virtual PeCourse Course { get; set; }
        public virtual PeUser User { get; set; }
    }
}

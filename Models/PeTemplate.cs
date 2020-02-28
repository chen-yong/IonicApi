using System;
using System.Collections.Generic;

namespace IonicApi.Models
{
    public partial class PeTemplate
    {
        public PeTemplate()
        {
            PeTest = new HashSet<PeTest>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? RestTime { get; set; }
        public int? LunchTime { get; set; }
        public int? ExamTime { get; set; }
        public TimeSpan? StartTime1 { get; set; }
        public TimeSpan? EndTime1 { get; set; }
        public TimeSpan? StartTime2 { get; set; }
        public TimeSpan? EndTime2 { get; set; }
        public TimeSpan? StartTime3 { get; set; }
        public TimeSpan? EndTime3 { get; set; }
        public TimeSpan? StartTime4 { get; set; }
        public TimeSpan? EndTime4 { get; set; }
        public TimeSpan? StartTime5 { get; set; }
        public TimeSpan? EndTime5 { get; set; }
        public TimeSpan? StartTime6 { get; set; }
        public TimeSpan? EndTime6 { get; set; }
        public TimeSpan? StartTime7 { get; set; }
        public TimeSpan? EndTime7 { get; set; }
        public TimeSpan? StartTime8 { get; set; }
        public TimeSpan? EndTime8 { get; set; }
        public TimeSpan? StartTime9 { get; set; }
        public TimeSpan? EndTime9 { get; set; }
        public TimeSpan? StartTime10 { get; set; }
        public TimeSpan? EndTime10 { get; set; }
        public TimeSpan? EndTime { get; set; }
        public bool IsDel { get; set; }
        public int CurrentUserId { get; set; }

        public virtual ICollection<PeTest> PeTest { get; set; }
    }
}

using IonicApi.Common;
using IonicApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Dtos
{
    public class StudentScoreInfoModel
    {
        public PeCourse Course { get; set; }
        public PagedList<PeCourseStudent> Students { get; set; }
        public IEnumerable<PeTest> Tests { get; set; }
    }
}

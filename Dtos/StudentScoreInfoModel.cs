using IonicApi.Common;
using IonicApi.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Dtos
{
    public class StudentScoreInfoModel
    {
        public PeCourse Course { get; set; }
        public IPagedList<PeCourseStudent> Students { get; set; }
        public IEnumerable<PeTest> Tests { get; set; }
    }
}

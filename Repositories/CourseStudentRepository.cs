using IonicApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Repositories
{
    public class CourseStudentRepository
    {
        private readonly PureExam_DevContext _context;
        public CourseStudentRepository(PureExam_DevContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        /// <summary>
        /// 根据课程ID查找课程所有的学生
        /// </summary>
        /// <param name="courseId">课程ID</param>
        /// <returns></returns>
        public IEnumerable<PeCourseStudent> GetStudentList(int courseId)
        {
            return _context.PeCourseStudent.Where(e => e.CourseId == courseId);
        }
        
    }
}

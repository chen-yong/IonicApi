using IonicApi.Common;
using IonicApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly PureExam_DevContext _context;
        public CourseRepository(PureExam_DevContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        /// <summary>
        /// 根据登录用户获取课程
        /// </summary>
        /// <param name="authtoken">authtoken</param>
        /// <returns></returns>
        public async Task<IEnumerable<PeCourse>> GeCoursesAsync(string authtoken)
        {
            int userId = AuthtokenUtility.GetId(authtoken);
            return await _context.PeCourse.Where(e=>e.Teacher== userId && !e.IsDel && e.Status == 0).OrderByDescending(e => e.UpdateTime).ToListAsync();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="courseId"></param>
        /// <returns></returns>
        public async Task<bool> CourseExistAsync(int courseId)
        {
            return await _context.PeCourse.AnyAsync(e => e.Id == courseId);
        }

    }
}

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
        public async Task<IEnumerable<PeCourse>> GetCoursesAsync(string authtoken)
        {
            int userId = AuthtokenUtility.GetId(authtoken);
            return await _context.PeCourse.Where(e=>e.Teacher== userId && !e.IsDel && e.Status == 0).OrderByDescending(e => e.UpdateTime).ToListAsync();
        }
        /// <summary>
        /// 根据课程Id获取课程
        /// </summary>
        /// <param name="courseId">课程Id</param>
        /// <returns></returns>
        public async Task<IEnumerable<PeCourse>> GetCourseAsync(int courseId)
        {
            return await _context.PeCourse.Where(e => e.Id == courseId && !e.IsDel && e.Status == 0).ToListAsync();
        }
        /// <summary>
        /// 课程是否存在
        /// </summary>
        /// <param name="courseId">课程Id</param>
        /// <returns></returns>
        public async Task<bool> CourseExistAsync(int courseId)
        {
            return await _context.PeCourse.AnyAsync(e => e.Id == courseId);
        }

        /// <summary>
        /// 增加课程
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <param name="peCourse">课程实体</param>
        public void AddCourse(int userId, PeCourse peCourse)
        {
            if (peCourse == null)
            {
                throw new ArgumentException(nameof(peCourse));
            }
            peCourse.Teacher = userId;
            peCourse.CreateUserId = userId;
            peCourse.CreateTime = DateTime.Now;
            peCourse.UpdateTime = DateTime.Now;
            peCourse.Psycj = 0;
            peCourse.Pzycj = 50;
            peCourse.Pkscj1 = 0;
            peCourse.Pkscj2 = 50;
            peCourse.IsAuthor = true;
            _context.PeCourse.Add(peCourse);
        }

        public void UpdateCourse(int courseId, PeCourse peCourse)
        {
            
        }

        public void DeleteCourse(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() >= 0;
        }
    }
}

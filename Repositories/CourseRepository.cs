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
            return await _context.PeCourse.Where(e => e.Teacher == userId && !e.IsDel && e.Status == 0).OrderByDescending(e => e.UpdateTime).ToListAsync();
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
        public async Task<PeCourse> GetCourse(int courseId)
        {
            return await _context.PeCourse.SingleOrDefaultAsync(e => e.Id == courseId);
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

        public void AddTest(int courseId, PeTest test)
        {
            if (test == null)
            {
                throw new ArgumentNullException(nameof(test));
            }
            //test.CreateUserId=
            test.CreateTime = DateTime.Now;
            test.IsOpen = true;
            if (test.TimeLimit > 0)
            {
                test.AutoSubmitOnTimeLimit = true;
            }
            test.Nid = GUIDUtility.GenerateCharID();
            _context.PeTest.Add(test);
        }

        public void DeleteTest(PeTest test)
        {
            throw new NotImplementedException();
        }

        public async Task<PeTest> GetTestAsync(int id)
        {
            return await _context.PeTest.SingleOrDefaultAsync(e => e.Id == id && !e.IsDel);
        }

        /// <summary>
        /// 获取练习，作业，考试，实验
        /// </summary>
        /// <param name="courseId">课程Id</param>
        /// <param name="mode">mode类型：Mode=1考试 Mode=2练习 Mode=3作业 Mode=4实验</param>
        /// <returns></returns>
        public async Task<IEnumerable<PeTest>> GetTestsAsync(int courseId, int mode)
        {
            return await _context.PeTest.Where(e => e.CourseId == courseId && e.Mode == mode && !e.IsDel).OrderBy(e => e.StartTime).ToListAsync();
        }
        /// <summary>
        /// 检索练习，作业，考试，实验
        /// </summary>
        /// <param name="courseId">课程Id</param>
        /// <param name="mode">mode类型：Mode=1考试 Mode=2练习 Mode=3作业 Mode=4实验</param>
        /// <param name="keyword">关键词</param>
        /// <returns></returns>
        public async Task<IEnumerable<PeTest>> GetTestsAsync(int courseId, int mode,string keyword)
        {
            var tests= _context.PeTest.Where(e => e.CourseId == courseId && e.Mode == mode && !e.IsDel);
            if (!string.IsNullOrEmpty(keyword))
            {
                keyword = keyword.Trim();
                tests = tests.Where(e => e.Name.Contains(keyword.Trim()));
            }
            return await tests.OrderByDescending(e => e.CreateTime).ToListAsync();
        }

        public async Task<bool> TestExistsAsync(int testId)
        {
            return await _context.PeTest.AnyAsync(e => e.Id == testId);
        }

        public void UpdateTest(int testId, PeTest test)
        {
            //throw new NotImplementedException();
        }

        /// <summary>
        /// 根据课程ID查找课程所有的学生成绩
        /// </summary>
        /// <param name="courseId">课程ID</param>
        /// <returns></returns>
        public async Task<IEnumerable<PeCourseStudent>> GradeListAsync(int courseId)
        {
            return await _context.PeCourseStudent.Where(e => e.CourseId == courseId).ToArrayAsync();
        }
        /// <summary>
        /// 获取学生汇总成绩
        /// </summary>
        /// <param name="courseId">课程Id</param>
        /// <param name="id">学生Id</param>
        /// <returns></returns>
        public async Task<IEnumerable<PeCourseStudent>> GradeAsync(int courseId, int id)
        {
            return await _context.PeCourseStudent.Where(e => e.CourseId == courseId && e.UserId == id).ToArrayAsync();
        }
        /// <summary>
        /// 成绩是否存在
        /// </summary>
        /// <param name="courseId">课程Id</param>
        /// <returns></returns>
        public async Task<bool> GradeExists(int courseId)
        {
            return await _context.PeCourseStudent.AnyAsync(e => e.CourseId == courseId);
        }

        public async Task<IEnumerable<PeResource>> GetResourcesAsync(int courseId, int parentId)
        {
            //共享资源
            var shareResources = _context.PeResource.Where(e => e.IsShared && !e.IsDel);
            //非共享资源
            var privateResources = from a in _context.PeResource
                                   where a.ParentId == parentId && !a.IsDel && (from b in _context.PeCourseResource where b.CourseId == courseId select b.ResourceId).Contains(a.Id)
                                   select a;
            //资源合并，时间倒序排序
            var resources = shareResources.Concat(privateResources).OrderByDescending(e => e.CreateTime);
            return await resources.ToListAsync();
        }

        public async Task<IEnumerable<PeResource>> GetResourcesAsync(int courseId, int parentId, string keyword)
        {
            //共享资源
            var shareResources = _context.PeResource.Where(e => e.IsShared && !e.IsDel);
            //非共享资源
            var privateResources = from a in _context.PeResource
                            where a.ParentId == parentId && !a.IsDel && (from b in _context.PeCourseResource where b.CourseId == courseId select b.ResourceId).Contains(a.Id)
                            select a;
            //资源合并，时间倒序排序
            var resources = shareResources.Concat(privateResources).OrderByDescending(e => e.CreateTime);
            //关键词检索
            if (!string.IsNullOrEmpty(keyword))
            {
                keyword = keyword.Trim();
                resources = resources.Where(e => e.FileName.Contains(keyword.Trim())).OrderByDescending(e => e.CreateTime);
            }
            return await resources.ToListAsync();
        }

        public async Task<bool> ResourceExistsAsync(int id)
        {
            return await _context.PeResource.AnyAsync(e=>e.Id==id);
        }

        public void AddResource(int courseId, PeResource peResource)
        {
            _context.PeResource.Add(peResource);
        }

        public void UpdateResource(int Id, PeResource peResource)
        {
            throw new NotImplementedException();
        }

        public void DeleteResource(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<PeResource> GetResourceAsync(int id)
        {
            return await _context.PeResource.SingleOrDefaultAsync(e => e.Id == id&&!e.IsDel);
        }
    }
}

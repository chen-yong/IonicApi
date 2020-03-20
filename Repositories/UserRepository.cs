using IonicApi.Common;
using IonicApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly PureExam_DevContext _context;
        public UserRepository(PureExam_DevContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        /// <summary>
        /// 查询课程所属的学生
        /// </summary>
        /// <param name="courseId">课程Id</param>
        /// <returns></returns>
        public async Task<IEnumerable<PeUser>> GetUsersAsync(int courseId)
        {
            var userId = from e in _context.PeCourseStudent where e.CourseId == courseId select e.UserId;
            var userList = from a in _context.PeUser where a.Id.ToString().Contains(userId.ToString()) select a;
            return await userList.ToListAsync();
        }

        /// <summary>
        /// 根据用户名或者真实姓名查询
        /// </summary>
        /// <param name="courseId">课程ID</param>
        /// <param name="keyword">关键词</param>
        /// <returns></returns>
        public async Task<IEnumerable<PeUser>> GetUsersAsync(int courseId, string keyword)
        {
            var userId = from e in _context.PeCourseStudent where e.CourseId == courseId select e.UserId;
            var userList = from a in _context.PeUser where a.Id.ToString().Contains(userId.ToString()) select a;
            if (string.IsNullOrEmpty(keyword))
            {
                return await userList.OrderBy(e=>e.Id).ToListAsync();
            }
            else
            {
                keyword = keyword.Trim();
                userList = userList.Where(e => e.UserName.Contains(keyword) || e.RealName.Contains(keyword));
                return await userList.OrderBy(e => e.Id).ToListAsync();
            }
        }
        /// <summary>
        /// 获取登录用户
        /// </summary>
        /// <param name="account">账号</param>
        /// <param name="pwd">密码</param>
        /// <returns></returns>
        public async Task<PeUser> GetUserAsync(string account, string pwd)
        {
            return await _context.PeUser.FirstOrDefaultAsync(e => (e.UserName == account || e.Email == account) && e.Password == pwd && e.UserIdentity01 != AppConstants.UserStatus.Deleted);
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="Id">用户Id</param>
        /// <returns></returns>
        public async Task<PeUser> GetUserAsync(int Id)
        {
            return await _context.PeUser.SingleOrDefaultAsync(e => e.Id == Id);
        }

        public void AddUser(PeUser user)
        {
            _context.PeUser.Add(user);
        }

        public void UpdateUser(PeUser user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(PeUser user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 用户名是否存在
        /// </summary>
        /// <param name="name">用户名</param>
        /// <returns></returns>
        public async Task<bool> UserExists(string name)
        {
            return await _context.PeUser.AnyAsync(e => e.UserName == name);
        }

        public async Task<bool> UserExistsAsync(int id)
        {
            return await _context.PeUser.AnyAsync(e => e.Id == id);
        }
        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() >= 0;
        }

    }
}

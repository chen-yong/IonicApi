﻿using IonicApi.Common;
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
            //select * from PE__user where Id in(select userId from PE__CourseStudent where courseId=courseId )
            // linq 子查询
            var usersList = from a in _context.PeUser
                            where (from b in _context.PeCourseStudent where b.CourseId == courseId select b.UserId).Contains(a.Id)
                            select a;
            usersList = usersList.Where(e => e.UserIdentity01 != AppConstants.UserStatus.Deleted).OrderBy(e => e.Id);
            return await usersList.ToListAsync();
        }

        /// <summary>
        /// 根据用户名或者真实姓名查询
        /// </summary>
        /// <param name="courseId">课程ID</param>
        /// <param name="keyword">关键词</param>
        /// <returns></returns>
        public async Task<IEnumerable<PeUser>> GetUsersAsync(int courseId, string keyword)
        {
            var usersList = from a in _context.PeUser
                            where (from b in _context.PeCourseStudent where b.CourseId == courseId select b.UserId).Contains(a.Id)
                            select a;
            usersList = usersList.Where(e => e.UserIdentity01 != AppConstants.UserStatus.Deleted).OrderBy(e => e.Id);
            if (!string.IsNullOrEmpty(keyword))
            {
                keyword = keyword.Trim();
                usersList = usersList.Where(e => e.UserName.Contains(keyword) || e.RealName.Contains(keyword) || e.UserIdentity00.Contains(keyword) || e.UserIdentity02.Contains(keyword));
                usersList = usersList.OrderBy(e => e.Id);
            }
            return await usersList.ToListAsync();
        }
        /// <summary>
        /// 获取登录用户
        /// </summary>
        /// <param name="account">账号</param>
        /// <param name="pwd">密码</param>
        /// <returns></returns>
        public async Task<PeUser> GetUserAsync(string account, string pwd)
        {
            //用户名或邮箱是account，且密码是pwd，且用户状态UserIdentity01没有被删除
            return await _context.PeUser.SingleOrDefaultAsync(e => (e.UserName == account || e.Email == account) && e.Password == pwd && e.UserIdentity01 != AppConstants.UserStatus.Deleted);
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
        public PeUser GetUser(int Id)
        {
            return  _context.PeUser.SingleOrDefault(e => e.Id == Id);
        }
        public string GetUserName(int Id)
        {
            return _context.PeUser.SingleOrDefault(e => e.Id == Id).UserName;
        }
        public string GetRealName(int Id)
        {
            return _context.PeUser.SingleOrDefault(e => e.Id == Id).RealName;
        }

        public void AddUser(PeUser user)
        {
            _context.PeUser.Add(user);
        }

        public void UpdateUser(PeUser user)
        {
           // throw new NotImplementedException();
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

        public PeUser GetUser(string name)
        {
            return _context.PeUser.SingleOrDefault(e => (e.UserName == name));
        }
    }
}

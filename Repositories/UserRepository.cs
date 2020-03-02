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
        /// 获取所有人员信息（连接数据库测试数据）
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<PeUser>> GetUsersAsync()
        {
            return await _context.PeUser.ToListAsync();
        }

        /// <summary>
        /// 获取用户
        /// </summary>
        /// <param name="account">账号</param>
        /// <param name="pwd">密码</param>
        /// <returns></returns>
        public async Task<PeUser> GetUserAsync(string account, string pwd)
        {
            return await _context.PeUser.FirstOrDefaultAsync(e => (e.UserName == account || e.Email == account) && e.Password == pwd && e.UserIdentity01 != AppConstants.UserStatus.Deleted);
        }

        public Task<PeUser> GetUserAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public void AddUser(PeUser user)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(PeUser user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(PeUser user)
        {
            throw new NotImplementedException();
        }
    }
}

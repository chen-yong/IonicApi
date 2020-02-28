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

        public void AddUser(PeUser user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(PeUser user)
        {
            throw new NotImplementedException();
        }

        public Task<PeUser> GetUserAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PeUser>> GetUsersAsync()
        {
            return await _context.PeUser.ToListAsync();
        }

        public Task<IEnumerable<PeUser>> GetUsersAsync(IEnumerable<int> Ids)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(PeUser user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserExistAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}

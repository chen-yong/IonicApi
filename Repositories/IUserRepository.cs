using IonicApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<PeUser>> GetUsersAsync();
        Task<PeUser> GetUserAsync(string account, string pwd);
        Task<PeUser> GetUserAsync(int Id);
        void AddUser(PeUser user);
        void UpdateUser(PeUser user);
        void DeleteUser(PeUser user);
    }
}

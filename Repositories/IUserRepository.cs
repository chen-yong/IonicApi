﻿using IonicApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IonicApi.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<PeUser>> GetUsersAsync(int courseId);
        Task<IEnumerable<PeUser>> GetUsersAsync(int courseId,string keyword);

        Task<IEnumerable<PeUser>> GetUsersTongxunAsync(string authtoken, string property00, string keyword);

        Task<PeUser> GetUserAsync(string account, string pwd);
        Task<PeUser> GetUserAsync(int Id);
        Task<PeUser> GetUserAsync(string authtoken);
        PeUser GetUser(int Id);
        string GetUserName(int Id);
        string GetRealName(int Id);
        void AddUser(PeUser user);
        void UpdateUser(PeUser user);
        void DeleteUser(PeUser user);
        Task<bool> UserExists(string name);
        PeUser GetUser(string name);
        Task<bool> UserExistsAsync(int id);
        Task<bool> SaveAsync();
    }
}

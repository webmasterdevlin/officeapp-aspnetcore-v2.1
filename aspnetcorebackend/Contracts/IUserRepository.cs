﻿using System.Collections.Generic;
using System.Threading.Tasks;
using aspnetcorebackend.Identity;
using aspnetcorebackend.Models.Entities;

namespace aspnetcorebackend.Contracts
{
    public interface IUserRepository
    {
        User Authenticate(LoginModel model);
        IEnumerable<User> GetAll();
        User GetById(int id);
        Task<User> CreateAsync(User user, string password);
        Task<User> UpdateAsync(User user, string password = null);
        Task DeleteAsync(int id);
    }
}
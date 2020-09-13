using BudgetApp.Data.Context;
using BudgetApp.Data.Models;
using BudgetAppBackend.Service.Exceptions;
using BudgetAppBackend.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetAppBackend.Service.Concretes
{
    class UserRepository : IUsersRepository
    {
        private readonly BudgetContext _context;

        public UserRepository(BudgetContext context)
        {
            this._context = context;
        }

        public async Task CreateUser(string name)
        {
            List<User> existingUsers = new List<User>(await GetUserByName(name));
            if (existingUsers.Count > 0)
            {
                throw new ExistingUserException("User already Exisits");
            }

            var newUser = new User() { UserName = name, TotalBalance = 0m };
            await _context.Users.AddAsync(newUser);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<User>> GetUserByName(string name)
        {
            return await _context.Users.Where(u => u.UserName == name).ToListAsync();
        }

        public async Task UpdateUserBalance(User user)
        {
            decimal newBalance = user.UserAccounts.Select(a => a.AccountBalance).ToList().AsQueryable().Sum();
            user.TotalBalance = newBalance;

            await _context.SaveChangesAsync();
        }
    }
}

using BudgetApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BudgetAppBackend.Service.Interfaces
{
    public interface IUsersRepository
    {
        Task CreateUser(string name);

        Task UpdateUserBalance(User user);

        Task<User> GetUserByName(string name);
    }
}

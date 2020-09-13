using BudgetApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BudgetAppBackend.Service.Interfaces
{
    public interface IAccountsRepository
    {
        Task CreateAccount(string accountName, AccountType accountType, string userName, decimal startingBalance);
        Task UpdateAccountBalance(Account account, decimal updatedBalance);
        Task DeleteAccount(Account account);
        Task<IEnumerable<Account>> FindAccountsByUser(User user);

    }
}

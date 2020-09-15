using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetApp.Data.Models
{
    public enum AccountType
    {
        CHECKING,
        SAVINGS
    }

    public class Account
    {
        public long Id { get; set; }
        public User User { get; set; }
        public string AccountName { get; set; }
        public AccountType AccountType { get; set; }
        public decimal AccountBalance { get; set; }
    }
}

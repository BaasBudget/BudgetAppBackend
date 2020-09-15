using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace BudgetApp.Data.Models
{
    public class User
    {
        [Key]
        public string UserName { get; set; }   
        public decimal TotalBalance { get; set; }
        public List<Account> UserAccounts { get; set; }
    }
}

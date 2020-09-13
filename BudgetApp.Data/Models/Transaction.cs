using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetApp.Data.Models
{
    public class Transaction
    {
        public long Id { get; set; }

        public DateTime Time { get; set; }

        public User User { get; set; }

        public Account TransactionAccount { get; set; }

        public Catagory Catagory { get; set; }

        public decimal Amount { get; set; }
    }
}

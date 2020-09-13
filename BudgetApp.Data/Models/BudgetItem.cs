using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetApp.Data.Models
{
    public class BudgetItem
    {
        public long Id { get; set; }
        public User User { get; set; }
        public Month Month { get; set; }
        public Catagory Catagory { get; set; }
        public decimal AllottedBalance { get; set; }
    }
}

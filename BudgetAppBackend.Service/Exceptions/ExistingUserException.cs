using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetAppBackend.Service.Exceptions
{
    class ExistingUserException : Exception
    {
        public ExistingUserException(string message) : base(message)
        {
        }
    }
}

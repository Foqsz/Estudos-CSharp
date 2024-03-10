using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities.Exceptions
{
    internal class AccountException : ApplicationException
    {
        public AccountException(string erro) : base(erro)
        {
        }
    }
}

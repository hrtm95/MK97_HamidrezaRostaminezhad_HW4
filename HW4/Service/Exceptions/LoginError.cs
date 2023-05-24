using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4.Repository.Exceptions
{
    public class LoginError : Exception
    {
        public LoginError() : base("the login faild try again") { }


    }
}

using HW4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4.Abstracts
{
    public interface IUserService
    {
        List<Users> GetAllUser();
        bool AddUser(Users user);
        bool UpdateUser(Users user);
        bool DeleteUser(Users user);
    }
}

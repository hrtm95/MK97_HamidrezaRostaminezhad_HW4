using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4.View
{
    public static class UserMenu
    {
        public static void Arival (string UserName)
        {
            Console.Clear ();
            Console.WriteLine($"Hello {UserName} enter number plese enter a number:");
            Console.WriteLine("1 - to show all users");
            Console.WriteLine("2 - to add user");
            Console.WriteLine("3 - to delete user");
            Console.WriteLine("4 - to update profile user");

        }
    }
}

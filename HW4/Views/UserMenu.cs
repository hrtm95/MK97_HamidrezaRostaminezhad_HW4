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
            Console.WriteLine("5 - to back login menu");

        }
        public static void loginOrRegester()
        {
            Console.Clear();
            Console.WriteLine("Plese Enter 1 to login:");
            Console.WriteLine("Plese Enter 2 for Rigester:");
        }
        public static void loginGetUsername()
        {
            Console.Clear();
            Console.WriteLine("Enter your Email:");
        }
        public static void loginGetPassword()
        {
            Console.WriteLine("Enter your Password:");
        }
        public static void WatingforContinue()
        {
            Console.WriteLine("press any kye to continue:");
            Console.ReadKey();
        }
    }
}

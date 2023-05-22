using HW4.Models;
using HW4.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Users users = new Users() { Id = 3 , Email = "hamidreza",Lastname = "maradi",Name = "hamid" , RoleId =3};
            Console.WriteLine("all users before add");
            Userservice userservice = new Userservice();
            List<Users> usrs = userservice.GetAllUser();
            foreach (Users usr in usrs)
            {
                Console.WriteLine(usr.Name);
            }
            Console.WriteLine("to test add user and ... press any key:");
            Console.ReadKey();
            userservice.AddUser(users);

            usrs = userservice.GetAllUser();
            foreach (Users usr in usrs)
            {
                Console.WriteLine(usr.Name);
            }
            Console.ReadKey();
        }
    }
}

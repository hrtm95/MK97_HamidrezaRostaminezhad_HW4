using HW4.Models;
using HW4.Repository;
using HW4.View;
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
            //this while is for exit from program 
            while (true)
            {
                UserMenu.loginOrRegester();
                string funcnumber = Console.ReadLine();
                int func;
                if (int.TryParse(funcnumber, out func))
                {
                    if (func == 1)
                    {
                        Users user = new Users();
                        UserMenu.loginGetUsername();
                        string Email = Console.ReadLine();
                        UserMenu.loginGetPassword();
                        string Password = Console.ReadLine();
                        UserMenu.Arival("hamidreza");
                    }
                    if (func == 2)
                    {

                    }
                    else
                    {
                        //eroor loign
                    }
                }
                else
                {
                    //erorr login 
                }




            }

            Console.ReadKey();
            Console.ReadKey();
        }
    }
}

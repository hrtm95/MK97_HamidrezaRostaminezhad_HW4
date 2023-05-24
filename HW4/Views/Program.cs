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
            Userservice userservice = new Userservice();
            //this while is for exit from program 
            while (true)
            {
                UserMenu.loginOrRegester();
                string loginnumber = Console.ReadLine();
                int LoginN;
                if (int.TryParse(loginnumber, out LoginN))
                {
                    if (LoginN == 1)
                    {

                        UserMenu.loginGetUsername();
                        string Email = Console.ReadLine();
                        UserMenu.loginGetPassword();
                        string Password = Console.ReadLine();
                        Users user = userservice.LoginUser(Email, Password);
                        if (user != null)
                        {
                            UserMenu.Arival(user.Name);
                            string UserFanc = Console.ReadLine();
                            int UserFancNum;
                            if (int.TryParse(UserFanc, out UserFancNum))
                            {
                                if (UserFancNum == 1)
                                {
                                    List<Users> users = userservice.GetAllUser();
                                    if (users != null)
                                    {
                                        foreach (Users user1 in users)
                                        {
                                            Console.WriteLine($"ID: {user1.Id}\t Name:{user1.Name}\t LastName:{user1.Lastname}\t Email:{user1.Email}\t ");
                                        }
                                        UserMenu.WatingforContinue();
                                    }
                                    else
                                    {
                                        //null file eroor
                                    }
                                }
                                else if (UserFancNum == 2)
                                {

                                }
                                else if (UserFancNum == 3)
                                {

                                }
                                else if (UserFancNum == 4)
                                {

                                }
                                else
                                {
                                    //erro func 
                                }
                            }
                            else
                            {
                                //error func
                            }

                        }
                        if (LoginN == 2)
                        {
                            // Rigester just in User admin service
                            // for regester new users : Coming soon :D
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
}
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

                            while (true)
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
                                            Console.Clear();
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
                                        Console.Clear();
                                        Users adduser = new Users();
                                        Console.WriteLine("Enter Email of user");
                                        adduser.Email = Console.ReadLine();
                                        Console.WriteLine("Enter Name of user");
                                        adduser.Name = Console.ReadLine();
                                        Console.WriteLine("Enter LastName of user");
                                        adduser.Lastname = Console.ReadLine();
                                        Console.WriteLine("Enter password of user");
                                        adduser.Password = Console.ReadLine();
                                        Console.WriteLine("Enter Mobile of user");
                                        adduser.Mobile = Console.ReadLine();
                                        Console.WriteLine("Enter berth Day of user like this ( 2003/2/13 ):");
                                        while (true)
                                        {
                                            string brithdate = Console.ReadLine();
                                            if (Validations.CheckDateTime(brithdate))
                                            {
                                                adduser.BirthDate = DateTime.Parse(brithdate);
                                                break;
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Enter true berth date like this 2003/2/13 or this 2003-2-13:");
                                            }

                                        }
                                        Console.WriteLine("Enter Role of user \n1 = admin\t 2 = user :");
                                        while (true)
                                        {
                                            int role;
                                            if (int.TryParse(Console.ReadLine(), out role) && (role == 1 || role == 2))
                                            {
                                                adduser.RoleId = role;
                                                break;
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Enter true Role Id (1 = admin\t 2 = user):");
                                            }
                                        }
                                        if (userservice.AddUser(adduser))
                                        {
                                            Console.WriteLine("add user id sucsess!!");
                                            UserMenu.WatingforContinue();
                                        }
                                        else
                                        {
                                            Console.WriteLine("The email is duplicate!! ");
                                            UserMenu.WatingforContinue();
                                        }


                                    }
                                    else if (UserFancNum == 3)
                                    {
                                        List<Users> users = userservice.GetAllUser();
                                        if (users != null)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Enter id to delete user:");
                                            foreach (Users user1 in users)
                                            {
                                                Console.WriteLine($"ID: {user1.Id}\t Name:{user1.Name}\t LastName:{user1.Lastname}\t Email:{user1.Email}\t ");
                                            }
                                            while (true)
                                            {
                                                int deletId;
                                                if (int.TryParse(Console.ReadLine(), out deletId))
                                                {
                                                    if (userservice.DeleteUser(deletId))
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("Delete is sucsessfull");
                                                    }

                                                    else
                                                    {
                                                        Console.WriteLine("ID not found!");
                                                    }
                                                    break;
                                                    UserMenu.WatingforContinue();
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("number isn't valid!\n");
                                                    Console.WriteLine("Enter valid number:");
                                                }

                                            }

                                        }
                                        else
                                        {
                                            //null file eroor
                                        }
                                    }
                                    else if (UserFancNum == 4)
                                    {

                                    }
                                    else if (UserFancNum == 5)
                                    {
                                        break;
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
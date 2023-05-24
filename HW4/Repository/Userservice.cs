using CsvHelper;
using HW4.Abstracts;
using HW4.DataBase;
using HW4.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HW4.Repository
{
    public class Userservice : IUserService
    {
        public string filePath = DataPath.PathFileUsers();
        public bool AddUser(Users user)
        {
            List<Users> users = new List<Users>();
            users = GetAllUser();
            var serarchuser = users.FirstOrDefault(serche => user.Email == serche.Email);
            user.Id = users.Max(r => r.Id)+1;
            if (serarchuser == null)
            {
                users.Add(user);
                SaveOnCsv(users);
                return true;
            }
            else
            {
                return false;
            }
                
        }

        public bool DeleteUser(Users user)
        {
            List<Users> users = new List<Users>();
            List<Users> tempusers = new List<Users>();
            users = GetAllUser();
            var serarchuser = users.FirstOrDefault(serche => user.Id == serche.Id);
            if (serarchuser != null)
            {
                foreach (Users Tuser in users)
                {
                    if (Tuser.Id != serarchuser.Id)
                        tempusers.Add(Tuser);
                }
                SaveOnCsv(tempusers);
                return true;
            }
            else
            {
                return false;
            }


            return false;
        }

        public List<Users> GetAllUser()
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Users>();
                if (records != null)
                {
                    return records.ToList();
                }                    
                else return null;
            }
            
        }

        public Users LoginUser(string Email,string password)
        {
            List<Users> users = new List<Users>();
            users = GetAllUser();
            Users user = users.FirstOrDefault(x => x.Email == Email && x.Password == password);
            return user;
        }

        public bool UpdateUser(Users user)
        {
            throw new NotImplementedException();
        }
        public bool SaveOnCsv(List<Users> users)
        {
            try
            {
                using (var writer = new StreamWriter(filePath))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteHeader<Users>();
                    csv.NextRecord();
                    foreach (var User in users)
                    {
                        csv.WriteRecord(User);
                        csv.NextRecord();
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4.DataBase
{
    public class DataPath
    {
        private static string workingDirectory;
        private static string projectDirectory;
        public static string PathFileUsers()
        {
            workingDirectory = Environment.CurrentDirectory;
            projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            return $"{projectDirectory}/DataBase/Users.csv";
        }
    }
}

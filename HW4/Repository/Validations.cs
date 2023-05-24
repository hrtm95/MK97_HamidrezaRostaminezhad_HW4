using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4.Repository
{
    public static class Validations
    {
        public static bool CheckDateTime(string date)
        {
            DateTime time;
            return DateTime.TryParse(date, out time);

        }
    }
}

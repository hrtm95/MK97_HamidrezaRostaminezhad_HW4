using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4.Repository.Exceptions
{
    public class CustomExeption : Exception
    {
        public CustomExeption() : base("costom erorr") { }
        public CustomExeption(string s) : base(s) { }
        //throw new CustomExeption();

    }
}

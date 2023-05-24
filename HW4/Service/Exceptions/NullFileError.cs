using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4.Service.Exceptions
{
    public class NullFileError: Exception
    {
        public NullFileError() : base("The file is Null or nut found:") { }
    }
}

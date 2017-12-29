using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    public class UserDefinedException : Exception
    {
        public UserDefinedException(string message) : base(message)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    public class StringAndStringBuilder
    {
        public void Display()
        {
            string msg = "Hi";
            msg = msg + "Hello";
            msg = msg + "Pragim";

            Console.WriteLine(msg);

            StringBuilder sb = new StringBuilder();
            sb.Append("Hi");
            sb.Append("Hello");
            sb.Append("Pragim");

            Console.WriteLine(sb.ToString());
        }
    }
}

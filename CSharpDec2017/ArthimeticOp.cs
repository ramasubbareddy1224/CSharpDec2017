using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    class ArthimeticOp
    {
        static void Main()
        {
            int first = 10;
            int second = 20;

            int add = first + second;
            int sub = first - second;
            int mul = first * second;
           
            Console.WriteLine("addition of first:" + first + " and second:" + second + " is :" + add);

            string output = string.Format("addition of first:{0} and second:{1} is:{2}", first, second, add);

            Console.WriteLine(output);

            Console.Read();

        }
    }
}

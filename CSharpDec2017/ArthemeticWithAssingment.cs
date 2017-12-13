using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    class ArthemeticWithAssingment
    {
        static void Main()
        {
            int first = 20;
            Console.WriteLine("before assign:" + first);  // 10
            first = first + 20;  // 20 + 20 => 40 
            first += 20;
            //first = first - 10;
            first -= 10;
            Console.WriteLine("after assign:" + first);  // 40


            Console.Read();
        }
    }
}

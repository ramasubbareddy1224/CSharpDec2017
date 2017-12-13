using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    class ConsoleRead
    {
        static void Main()
        {
            //int first = 10;
            //int second = 20;
            //int add = first + second;

            Console.WriteLine("enter first number");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number");
            int second = Convert.ToInt32(Console.ReadLine());

            int add = first + second;
            Console.WriteLine("addition:" + add);

            // string readvale = Console.ReadLine();

            //Console.WriteLine("You have entered:" + readvale);
            Console.ReadKey();
        }
    }
}

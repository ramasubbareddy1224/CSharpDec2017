using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    class IFElse
    {
        static void Main()
        {
            Console.WriteLine("enter first number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int second = Convert.ToInt32(Console.ReadLine());
            bool check = true;

            if (first >=0)
            {
                if (first > second)
                {
                    Console.WriteLine("first is Bigger");
                }
                else
                {
                    Console.WriteLine("Second is Bigger");
                }
            }
            else
            {
                Console.WriteLine("negative number");
            }

            Console.ReadKey();
        }
    }
}

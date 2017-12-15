using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    class IFElseIF
    {
        static void Main()
        {
            Console.WriteLine("enter alphabet");
            string input = Console.ReadLine();

            if (input == "a")
            {
                Console.WriteLine("Vowel");
            }
            else if (input == "e")
            {
                Console.WriteLine("Vowel");
            }
            else if (input == "i")
            {
                Console.WriteLine("vowel");
            }
            else if (input == "o")
            {
                Console.WriteLine("Vowel");
            }
            else if (input == "u")
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("Consonent");
            }

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    enum Days
    {
        Monday,
        Tuesday,
        Wednesday
    }
    class Switch
    {
        static void Main()
        {

            Console.WriteLine("enter alphabet");
            string input = Console.ReadLine();

            switch (input)
            {
                case "a":
                    Console.WriteLine("Vowel");
                    break;

                case "e":
                    Console.WriteLine("Vowel");
                    break;
                case "i":
                    Console.WriteLine("Vowel");
                    break;
                case "o":
                    Console.WriteLine("Vowel");
                    break;
                case "u":
                    Console.WriteLine("Vowel");
                    break;

                default:
                    Console.WriteLine("Consonent");
                    break;
            }

            switch (input)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine("Vowel");
                    break;

                default:
                    Console.WriteLine("Consonent");
                    break;
            }


            Console.ReadKey();
        }
    }
}

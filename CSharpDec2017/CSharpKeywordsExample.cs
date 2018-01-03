using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    public class CSharpKeywordsExample
    {
        const double PI = 3.14;
        readonly int intreadonly = 100;
        public CSharpKeywordsExample()
        {
            intreadonly = 200;
        }

        public void Display()
        {
            int x = 20, y = 10;

            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
            else
            {
                Console.WriteLine("x is less than or equal to y");
            }

            var result = (x > y) ? "x is greater than y" : "x is less than or equal to y";
            Console.WriteLine(result);

            int i = 100; // explicitly typed 

            var ivar = 100; // implicityly type
            ivar = 200;

            Console.WriteLine("Type of ivar is {0}", ivar.GetType().ToString());
            var str = "Hello World!!";
            Console.WriteLine("Type of str is {0}", str.GetType().ToString());


            // Object keyword
            object a = 10; // int
            a = "rama";


            // Boxing
            object strText = "Some Text";
            string text = strText.ToString();

            object iobj = 10;
            int intValue = (int)iobj;

            // Read Only and Const

            
            const int count = 10;
            
                    




        }
    }
}

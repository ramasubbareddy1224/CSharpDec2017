using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    class LogicalOp
    {
        static void Main()
        {
            int first = 10;
            int second = 20;

            bool output = true;

            //  true && true = true
            // true && false = false
            // false && true = false
            // false && false = false
            bool sec1 = ((first == 10) && (second >= 20) && (second < 20));  // if one statement is false then complete statement false

            bool sec2 = (first == 10) || (second > 30);  // true || false : true  // if one statement is true then complete statement true

            bool sec3 = !output;  // false;

            bool sec4;
            if (output == true)
                sec4 = false;
            else
                sec4 = true;

            sec4 = !output;


            Console.WriteLine(sec3);
            Console.Read();

        }


    }
}

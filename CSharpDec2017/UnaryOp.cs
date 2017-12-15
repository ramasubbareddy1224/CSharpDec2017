using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    class UnaryOp
    {
        static void Main()
        {
            int lenght = 0;
            int newlenght = 0;
            int count = 5;
            count = count + 1;  // 6
            //count += 1;    7
            Console.WriteLine("increment without unary:" + count);
            count = 5;

            lenght = count++ + ++count ;  // 5 + 7
            newlenght = count;
            Console.WriteLine("increment with unary:" + lenght);
            Console.WriteLine("increment with unary newlength:" + newlenght);

            int decCount = 5;
            int declenght = 0;
            int newdeclenght = 0;
            decCount = decCount - 1;
            Console.WriteLine("decrement without unary:"+decCount);
            decCount = 5;
            // decCount = --decCount;
            newdeclenght = decCount-- + --decCount;  // 5 + 3
            Console.WriteLine("decrement with unary:"+ newdeclenght);


            Console.ReadKey();

        }
    }
}

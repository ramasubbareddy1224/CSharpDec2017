using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    class RelationalOp
    {
        static void Main()
        {
            int first = 10;
            int second = 20;

            bool isFirstBigger = (first >= second);

            bool sec1 = first > second;     // false
            bool sec2 = first <= second;   // 10 <= 20 : true
            bool sec3 = first != second;   // 10 !=20 : true
            bool sec4 = first == second;   // 10 == 20 : false

            Console.WriteLine(sec1);

            Console.Read();
        }
    }
}

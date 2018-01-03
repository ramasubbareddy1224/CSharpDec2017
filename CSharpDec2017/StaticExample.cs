using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    public class StaticExample
    {
        int normalCount = 10;
        public static int Count = 10;
        public static void StaticDisplay()
        {
            Console.WriteLine("This is static display method");
        }

        public void Display()
        {
            Count += 20;
            normalCount += 20;
            Console.WriteLine("normal display method with normal Count:" + normalCount + " and static count:" + Count);
        }
    }
}

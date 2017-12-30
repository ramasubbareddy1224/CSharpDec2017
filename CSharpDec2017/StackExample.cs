using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    public class StackExample
    {
        public void Display()
        {
            Stack stackObj = new Stack();
            stackObj.Push(10);
            stackObj.Push("Pragim");
            stackObj.Push("Rama");
            stackObj.Push(10.2);

            Console.WriteLine("using foreach");
            foreach (var item in stackObj)
            {
                Console.WriteLine(item);
            }

            stackObj.Pop();
            stackObj.Pop();

            Console.WriteLine("pop using foreach");
            foreach (var item in stackObj)
            {               
                Console.WriteLine(item);
            }
        }
    }
}

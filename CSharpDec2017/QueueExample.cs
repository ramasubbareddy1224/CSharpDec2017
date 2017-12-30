using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    public class QueueExample
    {
        public void Display()
        {
            Queue QueObj = new Queue();
            QueObj.Enqueue(10);
            QueObj.Enqueue("Pragim");
            QueObj.Enqueue("Rama");
            QueObj.Enqueue(10.2);

            Console.WriteLine("using foreach");
            foreach (var item in QueObj)
            {
                Console.WriteLine(item);
            }

            QueObj.Dequeue();
            QueObj.Dequeue();

            Console.WriteLine("dequeue using foreach");
            foreach (var item in QueObj)
            {
                Console.WriteLine(item);
            }

        }
    }
}

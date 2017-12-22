using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    public abstract class AbstractClassExample
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public void NormalMethod()
        {
            Console.WriteLine("This is normal method");
        }

        public abstract void PrintMessage();

    }

    public class AbstractImplemention : AbstractClassExample
    {
        public override void PrintMessage()
        {           
            Console.WriteLine("Print Message");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    public class RefOutKeywordExample
    {
        public void Display(out int data)
        {
            data = 20;

            data = data + 10;
            Console.WriteLine("data value inside method:" + data);
        }
    }
}

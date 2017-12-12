using System;

namespace CSharpDec2017.Learning
{
    class HelloWorld
    {
        static void Main()
        {
            Console.WriteLine("Hello World Progarm");
            Console.WriteLine("Second Line");

            short scount = short.MaxValue;

            Console.WriteLine("short maxvalue:"+scount);
            
            int count = 10;

            int temparature = -20;
            
            Console.WriteLine("before count:" + count);
            string name = "pragim tech";

            count = 20;
            count = 40;
            Console.WriteLine("after count:" + count);

            char gender = 'M';

            double percent = 73.8;

            bool foodAvailable = true;

            int temp;
           // Console.WriteLine("print temp value:"+temp);


            Console.ReadKey();
        }
    }
}

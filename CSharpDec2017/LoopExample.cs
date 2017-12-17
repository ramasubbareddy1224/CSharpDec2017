using System;

namespace CSharpDec2017
{
    class LoopExample
    {
        static void Main()
        {
            int stop = 0;
            Console.WriteLine("loop started");
            for (int i = 1; i <= 10 && stop == 0; i++)  // 1 <= 10  == true  
            {
                if (i == 5)
                    stop = 1;
                   // break;
                Console.WriteLine(i);
            }

            Console.WriteLine("loop completed");
            Console.Read();
        }
    }
}

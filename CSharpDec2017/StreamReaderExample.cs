using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    class StreamReaderExample
    {
        public void ReadFile()
        {
            string file = @"D:\test.txt";
            using (StreamReader reader = new StreamReader(file))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
            Console.ReadKey();

        }
        public void WriteFile()
        {
            string file = @"D:/test.txt";
            using (StreamWriter writer = new StreamWriter(file,true))
            {
                writer.Write("Hello");
                writer.WriteLine("Hellow StreamWriter Class");
                writer.WriteLine("How are you!");
            }
            Console.WriteLine("Data Saved Successfully!");

        }
    }
}

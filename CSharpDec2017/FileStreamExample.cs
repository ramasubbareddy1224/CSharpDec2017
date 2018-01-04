using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
   public class FileStreamExample
    {
        public void WriteFile()
        {
            FileStream fs = new FileStream("D:\\test1.txt", FileMode.Append);
            byte[] bdata = Encoding.Default.GetBytes("Hello This is Rama!");
            fs.Write(bdata, 0, bdata.Length);
            fs.Close();
            Console.WriteLine("Successfully saved file with data : Hello File Handling!");
            //Console.ReadKey();

        }
    }
}

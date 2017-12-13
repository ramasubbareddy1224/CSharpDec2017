using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    class TypeConversion
    {
        static void Main()
        {
            // Boxing

            int i = 10;
            string converti = i.ToString();  // way 1
            string converti2 = Convert.ToString(i);  // way 2

            Console.WriteLine("printing i value:" + i);
            Console.WriteLine("printing converti value:" + converti);


            // UnBoxing
            string sval = "100";
            int unboxint =Convert.ToInt32(sval);
            double d = Convert.ToDouble(sval);

            

            object o = i;
            object o1 = converti;
            object o2 = 43.5;
            Console.WriteLine(o2);
            object o3 = "100aba basdd fs";




            Console.ReadKey();


        }
        //private int Test()
        //{
        //    int i,Default;
        //}
    }
}

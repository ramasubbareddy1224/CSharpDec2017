using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    public class ArrayExample
    {
        public void Display()
        {

            // initialize array
            int[] empIds = new int[3];


            // Assign values to array
            empIds[0] = 100;
            empIds[1] = 101;
            empIds[2] = 102;

            // Reading array values
            Console.WriteLine(empIds[0]);
            Console.WriteLine(empIds[1]);
            Console.WriteLine(empIds[2]);


            // Initailze and assign in same line
            int[] studentIds = { 200, 201, 202 };
            int[] student1Ids = new int[5] { 200, 201, 202, 203, 205 };

            // Reading array values
            Console.WriteLine(studentIds[0]);

            Console.WriteLine("using forloop");
            for (int i = 0; i < student1Ids.Length; i++)
            {
                Console.WriteLine(student1Ids[i]);
            }

            Console.WriteLine("Using foreach");
            foreach (var item in student1Ids)
            {
                Console.WriteLine(item);
            }

        }
    }
}

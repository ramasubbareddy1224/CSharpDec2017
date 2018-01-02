using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    public class GenericList
    {
        public void Display()
        {
            //int[] array = new int[3];


            //ArrayList AL = new ArrayList();
            //AL.Add(10);
            //AL.Add("pragim tech");

            List<int> intList = new List<int>();
            intList.Add(10);
            intList.Add(20);
            intList.Add(30);

            Console.WriteLine("using foreach");
            foreach (int item in intList)
            {
                Console.WriteLine(item);
            }

            List<Employee> empList = new List<Employee>();

            Employee empObj1 = new Employee();
            empObj1.ID = 1;
            empObj1.Name = "Rama";
            empObj1.Email = "rama@gmail.com";

            empList.Add(empObj1);

            Employee empObj2 = new Employee();
            empObj2.ID = 2;
            empObj2.Name = "Siva";
            empObj2.Email = "siva@gmail.com";

            empList.Add(empObj2);

            empList.Add(new Employee()
            {
                ID = 3,
                Name = "Krishna",
                Email = "krishna@gmail.com"

            });

            Console.WriteLine("print employees using foreach");
            foreach (var empObj in empList)
            {
                Console.WriteLine(string.Format("ID:{0}, Name:{1},Email:{2}", empObj.ID, empObj.Name, empObj.Email));
            }

            Console.WriteLine("print employees using for loop");
            for (int i = 0; i < empList.Count; i++)
            {
                Console.WriteLine(string.Format("ID:{0}, Name:{1},Email:{2}", empList[i].ID, empList[i].Name, empList[i].Email));

            }

        }
    }
}

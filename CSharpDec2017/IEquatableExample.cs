using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    public class IEquatableExample
    {
        public void Display()
        {
            bool isExist = false;
            int searhnum = 51;
            int[] nums = { 10, 5, 6, 7 };

            //foreach (var item in nums)
            //{
            //    if(item== searhnum)
            //    {
            //        isExist = true;
            //        break;
            //    }
            //}

            //Console.WriteLine(isExist);
            nums.Contains(searhnum);

            List<PermanantEmployeeEq> empObj = new List<PermanantEmployeeEq>() {
                new PermanantEmployeeEq {ID=10,Name="Rama" },
                new PermanantEmployeeEq { ID=2,Name="ABC"},
            };

            PermanantEmployeeEq searchEmployee = new PermanantEmployeeEq { ID = 2, Name = "ABC" };

            if(empObj.Contains(searchEmployee))
            {
                Console.WriteLine("found");
            }
            else
            {
                Console.WriteLine("not found");
            }
        }
    }

    public class PermanantEmployeeEq : IEquatable<PermanantEmployeeEq>
    {
        public int ID { get; set; }
        public string Name { get; set; }       

        public bool Equals(PermanantEmployeeEq other)
        {
            return ID == other.ID && Name==other.Name;
        }
    }
}

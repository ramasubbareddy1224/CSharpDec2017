using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    public class IComparableExample
    {
        public void Display()
        {
            int[] nums = { 10, 3, 6, 5 };
            Console.WriteLine("before sort");
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
            Array.Sort(nums);
            Console.WriteLine("after sort");
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

            PermanantEmployee[] empObj = {
                new PermanantEmployee {ID=10,Name="Rama" },
                new PermanantEmployee { ID=2,Name="ABC"},
            };
            Console.WriteLine("before sort");
            foreach (var item in empObj)
            {
                Console.WriteLine(string.Format("ID:{0},Name:{1}", item.ID, item.Name));
            }


            Array.Sort(empObj);

            Console.WriteLine("after sort");
            foreach (var item in empObj)
            {
                Console.WriteLine(string.Format("ID:{0},Name:{1}", item.ID, item.Name));
            }

        }
    }

    public class PermanantEmployee : IComparable<PermanantEmployee>
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int CompareTo(PermanantEmployee other)
        {
            return ID.CompareTo(other.ID);
        }

        public bool Equals(PermanantEmployee other)
        {
            return ID == other.ID;
        }
    }
    public class EmployeeComparer : IComparer<PermanantEmployee>
    {
        public EmpolyeeSort SortField { get; set; }

        public int Compare(PermanantEmployee x, PermanantEmployee y)
        {
            switch (SortField)
            {
                case EmpolyeeSort.ID:
                    return x.ID.CompareTo(y.ID);
                case EmpolyeeSort.Name:
                    return x.Name.CompareTo(y.Name);
                default:
                    break;
            }
            return x.ID.CompareTo(y.ID);
        }
    }
    public enum EmpolyeeSort
    {
        ID,
        Name
    }

}

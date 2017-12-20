using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    public class Employee
    {
        public int ID;
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }


        public int Marks { get; }


        public string FullName
        {
            get
            {
                return LastName + " " + FirstName;
            }

        }


        public Employee()
        {
            Marks = 80;
        }

        public void GetEmployee()
        {
            Console.WriteLine(string.Format("id:{0},name:{1}", ID, Name));

        }


    }
}

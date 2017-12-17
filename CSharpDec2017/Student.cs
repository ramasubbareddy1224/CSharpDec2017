using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    class Student
    {
        public int id;
        public string name;
        public string email;

        public int studentid = 100;
        public void GetStudent()
        {
            Console.WriteLine("get student method");
        }
        public void GetAllStudents()
        {
            Console.WriteLine("Get all student method");
        }
        public int getStudentId()
        {
            //int a = 10;
            //int b = a + 20;
            Console.WriteLine("inside getstudetid");
            return id;
            

        }
        public string getStudentName()
        {
            return name;
        }
    }
}

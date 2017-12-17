using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    public class MainEntry
    {
        static void Main()
        {
            Student studentObj = new Student();
            studentObj.GetStudent();
            studentObj.GetAllStudents();

            studentObj.id = 10;

            int studentId = studentObj.getStudentId();

            Console.WriteLine("student id:" + studentId);

            studentObj.name = "rama";
            string stringname = studentObj.getStudentName();

            Console.WriteLine("student name:" + stringname);

            Student studentObj1 = new Student();
            studentObj1.name = "pragim";
            string sname = studentObj1.getStudentName();
            Console.WriteLine("student1 obj :name:" + sname);

            Console.Read();
        }
    }
}

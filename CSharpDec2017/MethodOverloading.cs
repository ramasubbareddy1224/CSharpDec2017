using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    public class MethodOverloading
    {
        public void createStudent()
        {
            Console.WriteLine("student created");
        }
        public void createStudent(int id)
        {
            Console.WriteLine("student created with id:" + id);
        }
        public void createStudent(string name)
        {
            Console.WriteLine("student created with name:" + name);
        }
        //public int createStudent(int id)
        //{
        //    Console.WriteLine("student created with name:" + name);
        //    int a = 10;
        //    int b = a * id;
        //    return b;
        //}
        public void createStudent(int id, string name)
        {
            createStudent(name, id);
            createStudent(name, "pragim@hyd.com");
            Console.WriteLine(string.Format("student created with id:{0} name:{1}", id, name));

        }
        public void createStudent(string name, int id)
        {
            Console.WriteLine(string.Format("student created with id:{0} name:{1}", id, name));
        }
        public void createStudent(string name, string email)
        {
            Console.WriteLine(string.Format("student created with name:{0} email:{1}", name, email));
        }
    }
}

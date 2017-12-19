using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    public class ConstructorExample
    {
        static ConstructorExample()
        {
            Console.WriteLine("This is static constructor");
        }        
        public ConstructorExample()
        {
            Console.WriteLine("this is constructor");
        }

        public ConstructorExample(int id) : this()
        {
            Console.WriteLine("single parameter id:" + id);
        }

        public ConstructorExample(int id, string name) : this(id)
        {
            Console.WriteLine(string.Format(" two parameter id:{0},name:{1}", id, name));
        }

        public ConstructorExample(string name, int id)
        {
            Console.WriteLine(string.Format("id:{0},name:{1}", id, name));
        }

        public void ConstMethod()
        {
            Console.WriteLine("This is a sample method");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    public class SingleInheritanceParent
    {
        public SingleInheritanceParent()
        {
            Console.WriteLine("This is parent constructor");
            ID = 200;
        }
        public SingleInheritanceParent(int id)
        {
            Console.WriteLine("This is parent constructor with id parameter {0}", id);
        }
        public int ID { get; set; }
        public string Name { get; set; }

        public void PrintParentMethod()
        {
            Console.WriteLine("This is parent method");
        }
    }

    public class SIChild : SingleInheritanceParent
    {
        public int ID { get; set; }

        public SIChild() 
        {
            Console.WriteLine("This is child constructor");
        }
        public void PrintChildMethod()
        {

            ID = 100;
            base.Name = "Rama";
            Console.WriteLine("This is child method");
            Console.WriteLine(string.Format("parent id: {0},child Id:{1},Name:{2}", base.ID, ID, Name));
            PrintParentMethod();
            base.PrintParentMethod();
        }
    }

}

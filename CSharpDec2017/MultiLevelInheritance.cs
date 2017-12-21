using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    public class MultiLevelInheritanceParent
    {
        public MultiLevelInheritanceParent()
        {
            Console.WriteLine("This is parent constructor");
        }
        public int ID { get; set; }

        protected void Parent1Method()
        {
            Console.WriteLine("This is parent1 method");
        }

    }

    public class MultiLevelInheritanceParent2 : MultiLevelInheritanceParent
    {
        public MultiLevelInheritanceParent2()
        {
            Console.WriteLine("This is parent 2 constructor");
        }
        public int ID { get; set; }
        public void Parent2Mehtod()
        {
            int id = base.ID;
            base.Parent1Method();
            Console.WriteLine("This is parent2 method");
        }
    }

    public class MLChild : MultiLevelInheritanceParent2
    {
        public MLChild()
        {
            Console.WriteLine("This is child constructor");
        }
        public void ChidMethod()
        {
            int id = base.ID;
            base.Parent1Method();
            base.Parent2Mehtod();
            Console.WriteLine("This is multi level child method");
        }
    }

}

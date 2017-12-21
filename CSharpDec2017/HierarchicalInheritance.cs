using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    public class HierarchicalInheritanceParent
    {
        public void ParentMethod()
        {
            Console.WriteLine("This is Parent Method");
        }
    }

    public class HIChild1 : HierarchicalInheritanceParent
    {
        public void HIChildMethod()
        {
            base.ParentMethod();
            Console.WriteLine("This is child method");
        }
    }

    public class HIChild2 : HierarchicalInheritanceParent
    {
        public void HIChild2Method()
        {
           // base.ParentMethod();
            Console.WriteLine("This is child2 method");
        }        
    }

}

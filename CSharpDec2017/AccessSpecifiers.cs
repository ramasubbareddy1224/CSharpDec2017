using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    public class AccessSpecifiers
    {
        public string Name;
        private string Email;
        protected string Phone;
        protected internal string Addresss;

        public string GetEmail()
        {
            return Email;
        }

        public string getName()
        {
            //AccessSpecifiers obj = new AccessSpecifiers();
            //return obj.;

            return Name;
        }

        public string GetPhone()
        {
            return Phone;
        }

    }

    public class Child : AccessSpecifiers
    {
        public void ChildMethod()
        {
            
        }
    }

}

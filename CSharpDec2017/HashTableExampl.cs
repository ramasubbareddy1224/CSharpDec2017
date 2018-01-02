using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    public class HashTableExampl
    {
        public void Display()
        {
            Hashtable htObj = new Hashtable();
            htObj.Add("std1", 10);
            htObj.Add("std2", "std2@gmail.com");


            Console.WriteLine(htObj["std1"]);

            foreach (var item in htObj.Keys)
            {
                Console.WriteLine(htObj[item]);

                // Console.WriteLine(string.Format("key:{0} and value:{1}", item., item.Value));
            }

        }
    }
}

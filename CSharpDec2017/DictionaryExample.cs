using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    public class DictionaryExample
    {
        public void Display()
        {
            Dictionary<string, string> dictObj = new Dictionary<string, string>();
            dictObj.Add("std1", "std1@gmail.com");
            dictObj.Add("std2", "std2@gmail.com");
            dictObj.Add("std3", "std3@gmail.com");

            foreach (var item in dictObj)
            {
                Console.WriteLine(string.Format("key:{0} and value:{1}", item.Key, item.Value));
            }

            Dictionary<string, Employee> dictObj2 = new Dictionary<string, Employee>();
            dictObj2.Add("std1", new Employee { ID = 1, Name = "rama", Email = "rama@gmail.com" });

            foreach (KeyValuePair<string, Employee> item in dictObj2)
            {
                Console.WriteLine(string.Format("ID:{0},Name:{1}", item.Value.ID, item.Value.Name));
            }
        }
    }
}

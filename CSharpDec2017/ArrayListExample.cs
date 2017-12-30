using System;
using System.Collections;
using System.Collections.Generic;


namespace CSharpDec2017
{
    public class ArrayListExample
    {
        public void Display()
        {

            ArrayList ALObj = new ArrayList();
            ALObj.Add(10);
            ALObj.Add("Pragim");
            ALObj.Add("Rama");
            ALObj.Add(10.2);

            //Console.WriteLine("without loop");
            //Console.WriteLine(ALObj[0]);

            Console.WriteLine("using foreach");
            foreach (var item in ALObj)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine("using for");
            //for (int i = 0; i < ALObj.Count; i++)
            //{
            //    Console.WriteLine(ALObj[i]);
            //}

            Console.WriteLine("insert item");
            ALObj.Insert(2, "Tech");

            Console.WriteLine("using foreach after insert");
            foreach (var item in ALObj)
            {
                Console.WriteLine(item);
            }

            ArrayList ALInnerList = new ArrayList();
            ALInnerList.Add("inner List1");
            ALInnerList.Add("inner List2");

            ALObj.InsertRange(3, ALInnerList);

            Console.WriteLine("using foreach after insert range");
            foreach (var item in ALObj)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("search element");
            if (ALObj.Contains("Rama123"))
            {
                Console.WriteLine("element found");
            }
            else
            {
                Console.WriteLine("element not found");
            }

            ArrayList ALaddRangeObj = new ArrayList();
            ALaddRangeObj.Add("add range 1");
            ALaddRangeObj.Add("add range 2");

            ALObj.AddRange(ALaddRangeObj);
            Console.WriteLine("using foreach after add range");
            foreach (var item in ALObj)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("find cound of the ArrayList:"+ALObj.Count);

            ALObj.Reverse();

            Console.WriteLine("reverse the elements in the ArrayList");
            foreach (var item in ALObj)
            {
                Console.WriteLine(item);
            }

            ALObj.Remove("Rama");

            Console.WriteLine("remove element from ArrayList");
            foreach (var item in ALObj)
            {
                Console.WriteLine(item);
            }

            ALObj.RemoveAt(5);

            Console.WriteLine("remove element from ArrayList using RemoveAt");
            foreach (var item in ALObj)
            {
                Console.WriteLine(item);
            }

            ALObj.RemoveRange(2, 2);

            Console.WriteLine("remove element from ArrayList using RemoveRange");
            foreach (var item in ALObj)
            {
                Console.WriteLine(item);
            }
            ALObj.Clear();

            Console.WriteLine("remove all element from ArrayList using Clear");
            foreach (var item in ALObj)
            {
                Console.WriteLine(item);
            }

        }
    }
}

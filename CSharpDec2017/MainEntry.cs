﻿using System;
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
            //Student studentObj = new Student();
            //studentObj.GetStudent();
            //studentObj.GetAllStudents();

            //studentObj.id = 10;

            //int studentId = studentObj.getStudentId();

            //Console.WriteLine("student id:" + studentId);

            //studentObj.name = "rama";
            //string stringname = studentObj.getStudentName();

            //Console.WriteLine("student name:" + stringname);

            //Student studentObj1 = new Student();
            //studentObj1.name = "pragim";
            //string sname = studentObj1.getStudentName();
            //Console.WriteLine("student1 obj :name:" + sname);

            //Console.WriteLine("calling new student data");

            //studentObj1.addStudent(100, "rama");

            //studentObj1.addStudent(name: "rama", id: 100);


            //AccessSpecifiers accessSpecifierObj = new AccessSpecifiers();
            // accessSpecifierObj.Name;
            //accessSpecifierObj.a;

            //ConstructorExample constObj = new ConstructorExample(100,"rama");
            //constObj.ConstMethod();

            //ConstructorExample constObj2 = new ConstructorExample();
            //ConstructorExample constObj3 = new ConstructorExample();

            //MethodOverloading overloadObj = new MethodOverloading();
            //overloadObj.createStudent(10, "pragim");

            //Employee empObj = new Employee();
            //empObj.ID = 100;
            //empObj.Name = "Rama";
            //empObj.FirstName = "Rama";
            //empObj.LastName = "M";
            //// empObj.Marks = 80;
            //empObj.GetEmployee();
            //Console.WriteLine("marks:" + empObj.Marks);
            //Console.WriteLine("fullname is:" + empObj.FullName);

            //SIChild SIObj = new SIChild();
            //SIObj.PrintChildMethod();

            //MLChild MLObj = new MLChild();

            //HIChild1 HIC1Obj = new HIChild1();
            //HIC1Obj.HIChildMethod();


            //HIChild2 HIC1Obj2 = new HIChild2();
            //HIC1Obj2.HIChild2Method();

            //AbstractImplemention ACObj = new AbstractImplemention();
            //ACObj.PrintMessage();

            //AbstractVehicle SBObj = new SuzikiBalino();
            //SBObj.DisplayMessage();

            //ITransaction transObj = new Transactions();
            //Console.WriteLine(transObj.GetAmount());

            //Console.WriteLine(transObj.GetAmount());

            //StringAndStringBuilder SBObj = new StringAndStringBuilder();
            //SBObj.Display();

            //ArrayExample arrayObj = new ArrayExample();
            //arrayObj.Display();

            //ExceptionHandling exObj = new ExceptionHandling();
            //exObj.ThrowException();

            //ArrayListExample Obj = new ArrayListExample();
            //Obj.Display();

            //StackExample Obj = new StackExample();
            //Obj.Display();

            //QueueExample Obj = new QueueExample();
            //Obj.Display();

            //GenericList Obj = new GenericList();
            // Obj.Display();

            //HashTableExampl Obj = new HashTableExampl();
            //Obj.Display();

            //int data =10 ;
            //RefOutKeywordExample Obj = new RefOutKeywordExample();
            //Obj.Display(out data);
            //Console.WriteLine("print data after Display:" + data);

            // StaticExample.StaticDisplay();

            //Console.WriteLine(StaticExample.Count);

            //StaticExample Obj = new StaticExample();
            //Obj.Display();

            //StaticExample Obj2 = new StaticExample();
            //Obj2.Display();

            //StaticExample Obj3 = new StaticExample();
            //Obj3.Display();

            //FileStreamExample Obj = new FileStreamExample();
            //Obj.WriteFile();

            //StreamReaderExample Obj = new StreamReaderExample();
            //Obj.WriteFile();

            //IComparableExample Obj = new IComparableExample();
            //Obj.Display();

            IEquatableExample Obj = new IEquatableExample();
            Obj.Display();



            Console.Read();


        }
    }
}

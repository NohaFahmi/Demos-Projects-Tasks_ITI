using System;
using System.Collections.Generic;
using System.Text;

namespace D06
{
    abstract class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        //public virtual void DoWork()
        //{
        //    Console.WriteLine("Person ");
        //}

        #region Abstract

        abstract public void DoWork();//it will not have an implementation in the parent class, each child will have its own implementation

         //public void Display()
         //{
         //   Console.WriteLine("Name is ....");
         //}
        #endregion

    }
    class Student: Person
    {//static Binding
        public override void DoWork()
        {//this override 
            Console.WriteLine("Student ");
        }
    }

    class Employee: Person
    {
        public override void DoWork()
        {//this override
            Console.WriteLine("Employee ");
        }
    }
}
    

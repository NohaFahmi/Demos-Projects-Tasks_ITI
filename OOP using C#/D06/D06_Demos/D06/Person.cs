using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace D06
{
  abstract  class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }


        abstract public void DoWork();

        public void display()
        {
            Console.WriteLine($"name {Name} Age {Age}");
        }

        //public virtual   void DoWork()
        //{
        //    Console.WriteLine("Person ");
        //}
    }

    class Student : Person
    {
        #region Binding
        //Static Binding
        //public   void DoWork()
        //{
        //    Console.WriteLine(" Student");
        //}




        //Dynamic Binding
        //override  public void DoWork()
        //{
        //    Console.WriteLine(" Student");
        //} 
        #endregion
        public override void DoWork()
        {
            Console.WriteLine("student"); ;
        }
    }

    class Employee : Person
    {
        public override void DoWork()
        {
            Console.WriteLine("Employee"); ;
        }
    }

}

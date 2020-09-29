using System;
using System.Collections.Generic;
using System.Text;

namespace Day05
{
    class Employee
    {
        //attr
      public  int id;
     public   string name;
     public   double salary;
      static int count;

        public Employee()
        {
            count++;
        }

        //fun
        public void DoSomeWork()
        {
            Console.WriteLine(name);


        }


        public void countObject()
        {
            Console.WriteLine(count);

        }
    }
}

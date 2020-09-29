using System;
using System.Collections.Generic;
using System.Text;

namespace D05
{
    class Employee
    {
        public int id;
        public string name;
        public double salary;
        static int count;

        public Employee()
        {
            count++;
            
        }

        public void counter ()
        {
            Console.WriteLine(count);
        }

        public void DoSomething()
        {
            Console.WriteLine($"{name} and {id} and {salary}");
        }
    }
}

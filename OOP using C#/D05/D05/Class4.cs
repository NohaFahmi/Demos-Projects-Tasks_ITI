using System;
using System.Collections.Generic;
using System.Text;

namespace D05
{
    class Person
    {
        int Age;
        string Name;

        public Person()
        {

        }

        public void Show()
        {
            Console.WriteLine(5+6+7);
            
        }

        //we activate the override feature by using the virtual keyword in the parent
        virtual public void wakeUp()
        {
            Console.WriteLine(" 1PM ");
        }

       
    }

    class Employees:Person
    {
        int id;
        int salary;

        public Employees()
        {

        }

        public override void wakeUp()
        {
            base.wakeUp();// by using base it will be the same result because it is smae implementation
            //creating my own implementation
            Console.WriteLine("6 AM");
        }

        //this function has the same name of a func from the parent, but it overrided its implementation and will not excute it 

        //this is different from override is that when override the parent function I could add to the original implementation or override it, but without override I could override the implementation and also any child class of that child class will not see the parent func any more, only will see the child class func
        public void Show()
        {
            Console.WriteLine("Show Emp");
        }

    }

    class Student:Person
    {

    }

    class Manager:Employees
    {

    }
}

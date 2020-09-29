using System;

namespace D05
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Obj && Class Members
            //Employee e1 = new Employee();
            //Employee e2 = new Employee();

            //Employee e3 = new Employee();

            //Employee e4 = new Employee();


            //e1.counter();//1 
            // it is an obj member 

            //to make this function dependant on the class not obj, we need to put static keyword before attribute!!

            //e2.counter(); //4
            //e1.name = "Noha";
            //e1.DoSomething();
            //-----------------------------------------------

            DoingSmth do1 = new DoingSmth();
            //Those functions are dependant on each obj not the overall class

            //Console.WriteLine(do1.CmToInch(54));

            //Console.WriteLine(do1.InctToCm(3));

            //Here I created another obj but implemnted functions with same values, the result is two diff. objects with same results and that what obj member means :D

            DoingSmth do2 = new DoingSmth();

            //Console.WriteLine(do2.CmToInch(54));

            // Console.WriteLine(do2.InctToCm(3));


            //Now those funcs became class members by adding static keyword before function, so now I can use it for the whole class not every obj
            Console.WriteLine(DoingSmth.InctToCm(3));
            
            Console.WriteLine(DoingSmth.InctToCm(30));
           
            Console.WriteLine(DoingSmth.CmToInch(35));

            Console.WriteLine(DoingSmth.Area(5));


            #endregion

            #region CallingByReference

            int a = 5, b = 7;

            DoingSmth.Swap(a, b);
            Console.WriteLine($"a= {a} and b = {b}");

            #endregion

            #region Operator Overloading

            Point p1 = new Point() { X = 5, Y = 8 };
            Point p2 = new Point() { X = 3, Y = 4 };

            //Point = p1 + p2;//this doesn't work because these p1, p2 is a data type I created!!

            //So I need something called Operator Overloading
            //which means If I had my own created data type, I want to do operations on them!

            Point p3 = p1 + p2;
            Point p4 = ++p1;

            Console.WriteLine($"P1{p1}");
            Console.WriteLine($"P2{p2}");
            Console.WriteLine($"P3{p3}");
            Console.WriteLine($"P4{p4}");


            if(p1>p2)
            {
                Console.WriteLine("P! GT P2");
            }


            #endregion

            #region Override

            Person person1 = new Person();

            person1.wakeUp();//1pm

            Person person3; // This is just reference not oobject because there is no new keyword

            Person person2 = new Employees();
            Employees emp1 = new Employees();

            Student std1 = new Student();

            Manager m1 = new Manager();
            
            //what if I want to get a different result from function if I called it from employees obj??

            //That's why we need override
            //it will be overrided on the implementation of functions
            emp1.wakeUp();//1pm //6AM
            emp1.Show();
           

            //all classes inherited from the same parent or from a child of the parent are refernced to the original parent
            testRef(person2);
            testRef(emp1);
            testRef(std1);
            testRef(m1);

            m1.Show();

            static void testRef(Person p)
            {
                Console.WriteLine(p);
            }
            
            
            
            
            #endregion
        }
    }
}

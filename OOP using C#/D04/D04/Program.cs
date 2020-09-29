using System;
using System.Security.Cryptography.X509Certificates;

namespace D04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Class

            //Car c;
            //c = new Car();

            //another way to declaration and initialization

            Car c = new Car("Honda", 100, 50);//that is an error now because I had created my own constructor, so I must enter the params
            //c.setMax(25);
            c.MaxSpeed = 230;
            
            Console.WriteLine(c.MaxSpeed); //return the value of max speed

            

            #endregion

            #region Functions

            //int Sum(int x, int y)
            //{
            //    return x + y;
            //}

            //Sum(1, 3);

            #endregion

            #region Access Modifiers, Inheritance
            //Point3D p3 = new Point3D();
            //p3.setX(2);

            
            //Point p1 = new Point();

            #endregion

            #region Constructor
            //I don't have a constructor that takes three params!
            //I only have the param. less Constructor which created automatically when initializing the object

            Car c2 = new Car("BMW", 220, 60);

            Car c1 = new Car();

            Car c4 = new Car("Marc", 90);
            //Console.WriteLine(c.ToString());
            //Console.WriteLine(c1.ToString());
            //Console.WriteLine(c2.ToString());
            //Console.WriteLine(c4.ToString());


            #endregion

            #region Overloading

            //TestOverloading.Print(1);
            //TestOverloading.Print(1, 5);
            //TestOverloading.Print("Hello");
            //TestOverloading.Print("Hello", 3.5f);
            //TestOverloading.Print(3.5f, "Hello");
            #endregion

            #region Class Constructor Chaining
            Point3D p1 = new Point3D(3, 5, 7);

            
            #endregion
        }
    }
}

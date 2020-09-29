using System;
using System.Collections.Generic;
using System.Text;

namespace D05
{
    class DoingSmth
    {
        int x;
        int y;
        static double pi;

        //in that static constructor, we don't need access modifier,
        //because I don't need to use it as when I use any value from it, the program will call it automatically

        static DoingSmth()
        {
            pi = 3.14;
            Console.WriteLine("Static Constructor!!");
        }

        //to give the static attr a vlaue, we need a static Constructor

        public DoingSmth()
        {
           

        }
        public static double InctToCm(double Inch)
        {
            return Inch * 2.5;
        }

        public static double CmToInch(double Cm)
        {
            return Cm / 2.5;
        }

        public static double Area(double r)
        {

            //all attrs used in static func must be static also
            return r * r * pi;
        }

        public static void Swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;


        }
    }
}

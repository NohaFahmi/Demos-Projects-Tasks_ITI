using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Day05
{
    class DoSomeWork
    {
        static int a;
        static int b;
    static  double pi;
        public static double Pi { get { return pi; } set { pi = value; } }


        static DoSomeWork()
        {
            pi = 3.14;
            Console.WriteLine("static constructor");
        }

        public DoSomeWork()
        {
           // pi = 3.14;
        }
        //public double InchToCm(double Inch)
        //{
        //    return Inch * 2.5;
        //}
        //public double CMToInch(double Cm)
        //{
        //    return Cm / 2.5;
        //}

        public static double InchToCm(double Inch)
        {
            return Inch * 2.5;
        }
        public static double CMToInch(double Cm)
        {
            return Cm / 2.5;
        }


        public static double Area(Double r)
        {
          
            return r * r * pi;
        }


        public static void SWAP(ref int a,ref int b)
        {
            int temp = a;
            
            a = b;
            b = temp;
        }

        public static void MulSum(int x,int y,out int s, out int mul)
        {
            s= x + y;
           mul= x * y;
        }
        public static int sum(int num1,int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

    }
}

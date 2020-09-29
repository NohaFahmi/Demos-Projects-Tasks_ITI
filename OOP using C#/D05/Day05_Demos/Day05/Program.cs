using System;

namespace Day05
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Static Members
            //Employee e1 = new Employee();
            //Employee e2 = new Employee();
            //Employee e3 = new Employee();
            //Employee e4 = new Employee();
            //e1.name = "Hamada";
            //e1.DoSomeWork();
            //e1.countObject(); 

            #region V1
            //DoSomeWork do1 = new DoSomeWork();
            //Console.WriteLine(do1.CMToInch(54));
            //Console.WriteLine(do1.InchToCm(3));

            //DoSomeWork do2 = new DoSomeWork();
            //Console.WriteLine(do2.CMToInch(54));
            //Console.WriteLine(do2.InchToCm(3));

            #endregion

            #region V2
            // Console.WriteLine(DoSomeWork.InchToCm(3));
            // Console.WriteLine(DoSomeWork.CMToInch(54));


            //// DoSomeWork.Pi = 3.14;
            // Console.WriteLine(DoSomeWork.Area(5));



            #endregion

            #endregion

            #region Function/ ref/OUt/ Param
            //int x = 5, y = 7;
            ////call by value
            //// DoSomeWork.SWAP(a,b);

            ////call by refernce
            //DoSomeWork.SWAP(ref x, ref y);

            //Console.WriteLine($"A={x} B={y}");
            //// int sum=0, mul=0;

            //// DoSomeWork.MulSum(x, y,ref sum,ref mul);

            ////Enum.TryParse(Console.ReadLine(), out int g);
            ////int sum, mul;
            //DoSomeWork.MulSum(x, y, out int sum, out int mul);
            //Console.WriteLine($"sum {sum} mul={mul}");


            ////ParamArray

            //// Console.WriteLine(DoSomeWork.sum(new int[] { 3, 4, 5, 6, 7, 8, 9, 6 }));

            //Console.WriteLine(DoSomeWork.sum(3, 4, 5, 6, 7, 8, 9, 6, 9, 3));



            #endregion


        }
    }
}

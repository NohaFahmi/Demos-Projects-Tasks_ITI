using System;
using System.Diagnostics;
using System.Text;

namespace D03
{
    //struct emp
    //{
    //    int id;
    //    string name;
    //    double salary;
    //}

     enum Branches:byte
    {
        C=101, Alx=102,Mansoura
       // C = 101, A=102,Mansoura
    }
    
    class Program
    {
       
        
        static void Main(string[] args)
        {
            #region StringBuilder

            //Stopwatch timer = new Stopwatch();
            //timer.Start();
            //string s = " Hello";//Immutable Datatype

            //s = "Helloo";

            //StringBuilder SB = new StringBuilder("Hello");//Mutable
            //SB.Append("o");

            // Console.WriteLine(SB);



            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);

            #endregion

            #region Refernce

            //  int x = default;
            //  int y = 6;

            //  object o1=default;//Null
            //  o1 = new object();
            //  Console.WriteLine(o1.GetHashCode());
            //  object o2 = o1;
            //  Console.WriteLine(o2.GetHashCode());

            //  int[] arr = default;
            //  Console.WriteLine(arr?.Length);

            // int? l= arr?.Length;


            //  //Implicit Typed Local Variable
            //  // var v1 = null;
            //  int x2 = 5;
            //  x2 = "  ";
            //  var v = 2.3;
            //  Console.WriteLine(v.GetType());
            // // Console.WriteLine(v1.GetType());

            //  v = 3;
            //  Console.WriteLine(v.GetType());
            ////  v = " ";
            ///

            //var v = new int[] { 1, 2, 4 };
            //Console.WriteLine(v.GetType());





            #endregion

            #region Boxing/UnBoxing




            #endregion

            #region Struct
            //string emp1Name = "hamada";
            //int emp1Age = 12;
            //double Emp1salary = 23.5;

            //string emp2Name = "hamada";
            //int emp2Age = 12;
            //double Emp2salary = 23.5;

            //string emp2Name = "hamada";
            //int emp2Age = 12;
            //double Emp2salary = 23.5; string emp2Name = "hamada";
            //
            //x=4;
            //x=5;

            //Employee emp1=new Employee();
            //emp1.setId(4);
            //emp1.setId(5);
            ////emp1.Id = 1;
            ////emp1.name = "Hamada";

            ////emp1.Id = 33;
            ////emp1.salary = 800;

            //emp1.setId(-1);

            //Console.WriteLine(emp1);


            #endregion

            #region Enum

            Branches b1 = Branches.Alx;
            Branches b2 = Branches.Alx;
            Branches b3 = Branches.Mansoura;
            Branches b4 =(Branches) 12;
            Branches b5 = (Branches)101;

            //Bit Flag Enum

            #endregion

        }
    }
}

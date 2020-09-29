using System;

namespace D06
{
    class Program
    {

        public static void Print(int N=5,string Pattern="#")
        {
            for(int i=0;i<N;i++)
                Console.Write(Pattern);
            Console.WriteLine();
        }

        public static int sum(params int[] arr  )
        {
            int sum = 0;
            foreach (int item in arr)
                sum += item;
            arr[0] = 5;
            return sum;
        }

        public static void Show(Person[] pArr )
        {
            for(int i=0;i<pArr.Length;i++)
            {
                pArr[i].DoWork();
            }

        }

        public static void Display(TypeA t )
        {
            t.DoWork();

        }


        public static void ShowSeries(Iseries series)
        {
            for(int i=0;i<5;i++)
                Console.Write(series.GetNext());

            series.Reset();

        }



        static void Main(string[] args)
        {
            #region DefualtParameter/NamedParameter
            // Print(10,"*");
            // Print(15, "$");
            // Print(7);
            // Print();
            // //Print("-_-");
            // Print(Pattern:"-_-");
            // Print(Pattern:"-_-",N:15);

            // int[] arr1 = new int[] { 1, 4, 7, 8, 9 };
            // sum(arr1);

            // Console.WriteLine(arr1[0]);
            //// Console.WriteLine(sum(1, 4, 7, 8, 9 )); 
            #endregion

            #region Static/Dynamic Binding

            //Person p1 = new Person();
            //Student s1 = new Student();
            //s1.DoWork();

            //Person p2 = new Student();

            //p2.DoWork(); 
            #endregion

            #region Abstract

            //TypeB t1 = new TypeB();

            //TypeA t2 = new TypeB();

         //  Display(t1);


            #endregion

            #region Interface

            EvenNum s1 = new EvenNum();
            // ShowSeries(s1);

            Fib s2 = new Fib();
            ShowSeries(s2);


            #endregion







        }
    }
}

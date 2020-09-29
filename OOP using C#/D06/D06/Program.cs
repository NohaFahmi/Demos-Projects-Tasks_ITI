using System;
using System.Security.Cryptography.X509Certificates;

namespace D06
{
    class Program
    {

        #region default& Named Prams
        public static void Print(int N = 4, string Pattern = "-")
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write(Pattern);

            }
            Console.WriteLine();
        }
        #endregion

        #region array Prams

        public static int Sum(int [] arr)
        {
            int sum = 0;
            foreach(int item in arr)
            {
                sum += item;
            }
            return sum;
        }
        #endregion

        #region Static/Dynamic Binding

        public static void Show(Person []  pArr)
        {
            for (int i=0; i<pArr.Length; i++)
            {
                pArr[i].DoWork();

            }

            //if I sent any child class of Person Class, it will be accepted into this func, because it is a reference of it.

        }
        #endregion

        #region Interface

        public static void ShowSeries(ISeries S)
        {
            for(int i =0; i<5; i++)
            {
                Console.WriteLine(S.GetNext());
               
            }

            S.Reset();
        }
        #endregion
        static void Main(string[] args)
        { 
            #region Static/Dynamic Binding
            //Print(10, "#");
            //Print();
            //Print(10);
            //Print("*"); I can't eneter the second params directly because the func expected that it is the first arg.
            //I can use the named parameter, I give it a name

            //Print(Pattern:"*");
            // int[] arr1 = new int[] { 1, 4, 6, 7, 6, 19 };
            //arr1[5] = 20;
            //Console.WriteLine(Sum(arr1));//I send it as an array

            // Console.WriteLine(Sum(1, 4, 5, 7, 9));
            
            #endregion
            
            #region Static/Dynamic Binding
            //Person p1 = new Person();
            //Student s1 = new Student();

            //Person p2 = new Student();
            //s1.DoWork();
            //p2.DoWork();// it will run the function in the person class because it thinks that p2 is a reference of Person class 
            #endregion

            #region abstract

            static void Test(TypeA t)
            {
                t.DoSomeWork();
            }

            TypeB T1 = new TypeB();
            Test(T1);

            TypeC t2 = new TypeC();
            Test(t2);



            #endregion

            #region Interface

            EvenNum s1 = new EvenNum();
            ShowSeries(s1);

            FibNum s2 = new FibNum();
            ShowSeries(s2);

            #endregion
        }


    }
}

using System;
using System.Collections.Generic;

namespace D07
{   [Flags]
    enum Permission
    {
        read=1, write=2, excute=4, delete=8
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region Composotion/Aggergation
            Car c1 = new Car("BM", 120, new Engine(1, 2020));
            Engine e1 = new Engine(1, 2020);

            Car c2 = new Car("NM", 130, e1);
            #endregion

            ///<summary>
            ///describe the function
            ///</summary>
            

            #region Copy Constructor
            TypeA o1 = new TypeA(1, 2);
            TypeA o2 = new TypeA(5,4);

            o2 = new TypeA(o1);

            Console.WriteLine($"{ o2} {o1}");
            #endregion

            #region bit flage enum
            Permission p1 = Permission.read;
            Permission p2 = (Permission) 4;
            Permission p3 = (Permission)3;//there is no value equal 3 in enum!!
            //so we want to make a combination between two values to get 3 value
            Permission p4 = (Permission)15;//there is no value equal 3 in enum!!


            Console.WriteLine(p2);
            Console.WriteLine(p1);
            Console.WriteLine(p3);
            Console.WriteLine(p4);



            #endregion

            #region List
            //data type that accepted into list is varaible, I could make it accepts every time a diff. data type
            //List<> is generic
            
            //list is normal
            List<int> list = new List<int>();
            list.Add(4);
            list.Add(2);
            list.Add(5);
            list.Add(15);
            list.Add(6);

            Console.WriteLine(list.Count);
            //the list has an array and it create an initial capacity = 4 elements and then increased it by double

            Console.WriteLine(list.Capacity);


            #endregion
        }
    }
}

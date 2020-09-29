using System;
using System.Collections.Generic;
using System.Text;

namespace D04
{
    class TestOverloading
    {
        #region overLoading functions

        public static void Print(int x)
        {
            Console.WriteLine($"{x}");
        }
        //so I can write mulitple functions with same
        //name but I must change the param type or params count
        //or the order of prarms
        //or in case of different data type params, we can change the returned data type


        public static void Print(int x, int y)
        {
            Console.WriteLine($"{x}{y}");
        }
        //public static void Print(string s)
        //{
        //    return $"{s}";
        //}

        public static string Print(string s)
        {
            return $"{s}";
        }

        public static void Print(string s, float z)
        {
            Console.WriteLine($"{s}{z}");
        }

        public static void Print(float z, string s)
        {
            Console.WriteLine($"{s}{z}");
        }



        #endregion
    }
}

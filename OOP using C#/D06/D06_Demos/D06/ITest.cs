using System;
using System.Collections.Generic;
using System.Text;

namespace D06
{
     interface ITest
    {
        //public
        int fun1();
        void fun2(string s);
      private  void fun3()
        {
            Console.WriteLine("new Feature");
        }
    }
}

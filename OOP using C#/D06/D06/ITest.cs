using System;
using System.Collections.Generic;
using System.Text;

namespace D06
{
    interface ITest
    {

        //public by default

        int func1();

        void func2();

        void func3()
        {
            //default implementation
            Console.WriteLine("default implementation");
        }
    }
}

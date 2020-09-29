using System;
using System.Collections.Generic;
using System.Text;

namespace D06
{
    
    abstract class TypeA
    {
        public int x { get; set; }

        public int y { get; set; }

        abstract public void DoSomeWork();
    }

    class TypeB: TypeA
    {
        public override void DoSomeWork()
        {
            Console.WriteLine("this is function");
        }

    }

    class TypeC: TypeB
    {
        public override void DoSomeWork()
        {
            Console.WriteLine("this is type C");
        }
    }

    
}

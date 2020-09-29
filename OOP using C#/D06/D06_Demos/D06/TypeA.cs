using System;
using System.Collections.Generic;
using System.Text;

namespace D06
{
   abstract class TypeA
    {
        public int x { get; set; }
       // public abstract int y { get; set; }

        public abstract void DoWork();
    }

    class TypeB : TypeA
    {
       // public override int y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void DoWork()
        {
            Console.WriteLine(" Override Abstract Fun"); 
        }
    }
}

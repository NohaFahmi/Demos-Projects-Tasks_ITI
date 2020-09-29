using System;
using System.Collections.Generic;
using System.Text;

namespace D06
{
    class Fib : Iseries
    {
        
        public int Current { get; set; }
        public int Prev { get; set; }

        public Fib()
        {
            Current = 1;
            Prev = 0;
        }
        public int GetNext()
        {

            int temp = Current;
            Current = Current + Prev;
            Prev = temp;
            return Current;
        }

        public void Reset()
        {
           Current=1 ;
            Prev = 0;
        }
    }
}

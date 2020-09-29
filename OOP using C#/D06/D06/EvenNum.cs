using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace D06
{
    class EvenNum: ISeries
    {
        public int current { get; set; }
        public int GetNext()
        {
            return current+=2;
        }

        public void Reset()
        {
            current = 0;
        }
    }

    class FibNum: ISeries
    {
        
        public int current { get; set; }
        public int prev { get; set; }

        public FibNum()
        {
            current = 1;
            prev = 0;
        }
        public int GetNext()
        {
            
            int temp = current;

            current = current + prev;
            prev = temp;

            return current;
        }

        public void Reset()
        {
            current = 1;
            prev = 0;

        }
    }
}

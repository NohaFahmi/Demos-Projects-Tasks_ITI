using System;
using System.Collections.Generic;
using System.Text;

namespace D06
{
    class EvenNum : Iseries
    {
        public int Current { get; set; }

        public int GetNext()
        {
            return Current+=2;
        }

        public void Reset()
        {
            Current=0;
        }
    }
}

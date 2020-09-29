using System;
using System.Collections.Generic;
using System.Text;

namespace D07
{
    class TypeA
    {

        int x;
        int y;

        public TypeA (int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public TypeA(TypeA NewObj)
        {
            x = NewObj.x;
            y = NewObj.y;
        }


    }
}

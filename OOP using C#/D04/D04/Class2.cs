using System;
using System.Collections.Generic;
using System.Text;

namespace D04
{
    class Point3D:Point
    {
        int z;

        public Point3D(int _x, int _y, int _z):base(_x, _y)
        {
            
            z = _z;
        }
        public void setX (int _x)
        {
           x = _x; 
            //it is not shown because it is private,
        //Now it is shown beacuse of using Protected
        }
    }
}

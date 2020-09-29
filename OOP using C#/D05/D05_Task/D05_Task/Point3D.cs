using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace D05_Task
{
   
    class Point2D
    {
        protected int x, y;

        public Point2D()
        {
            x = 0;
            y = 0;
        }

        public Point2D(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
  
    }
    class Point3D:Point2D
    {

        int z;

        public Point3D()
        {
            z = 0;
        }

        public Point3D (int _z) : base(0, 0)
        { 
            z = _z;
        }
         
        public Point3D(int _x, int _y, int _z) :base ( _x, _y)
        {
            z = _z;
        }
        public static Point3D operator +(Point3D l, Point3D r)
        {
            return new Point3D(l.x + r.x, l.y + r.y, l.z + r.z);
        }
        public static Point3D operator -(Point3D l, Point3D r)
        {
            return new Point3D(l.x - r.x, l.y - r.y, l.z - r.z);
        }

        public  static Point3D operator ++(Point3D p)
        {
            return new Point3D(p.x+1, p.y+1, p.z+1);
        }

        public static Point3D operator --(Point3D p)
        {
            return new Point3D(p.x-1, p.y-1, p.z-1);
        }
        public static Point3D operator /(Point3D l, Point3D r)
        {
            return new Point3D(l.x/r.x, l.y/r.y, l.z/r.z);
        }
        public static Point3D operator *(Point3D l, Point3D r)
        {
            return new Point3D(l.x * r.x, l.y * r.y, l.z * r.z);
        }

        public static bool operator >(Point3D l, Point3D r)
        {
            if(l.x == r.x)
            {
                if(l.y == r.y)
                {
                    if(l.z == r.z)
                    {
                        return l.z > r.z;
                    }
                    else
                    {
                        return l.z > r.z;
                    }
                }
                else
                {
                    return l.y > r.y;
                }
            }
            else
            {
                return l.x > r.x;
            }
        }

        public static bool operator <(Point3D l, Point3D r)
        {
            if (l.x == r.x)
            {
                if (l.y == r.y)
                {
                    if (l.z == r.z)
                    {
                        return l.z < r.z;
                    }
                    else
                    {
                        return l.z < r.z;
                    }
                }
                else
                {
                    return l.y < r.y;
                }
            }
            else
            {
                return l.x < r.x;
            }
        }

        public string Show()
        {
            return $"Result = ({x} , {y}, {z})";
        }
        public override string ToString()
        {
           return $"Point = ({x} , {y}, {z})";
        }
    }
}

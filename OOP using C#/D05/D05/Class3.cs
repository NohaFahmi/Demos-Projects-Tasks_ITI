using System;
using System.Collections.Generic;
using System.Text;

namespace D05
{
    class Point
    {

        int x;
        int y;

        //I can write those and not write x, y attrs if I will not create any restirction on x, y (just get and set)
        public int X { get; set; }
        public int Y { get; set; }

        //So I need something called Operator Overloading
        //which means If I had my own created data type, I want to do airthmetic operations on them!

        // return data type operator
        public static Point operator +(Point left, Point right)
        {
            return new Point() { X = left.X + right.X, Y = left.Y + right.Y };
        }
        //Unary Operator
        public static Point operator ++(Point p)
        {

            return new Point() { X = p.X + 1, Y = p.Y + 1 };
        }
        
        //Comparison Operators

        public static bool operator>(Point l, Point r)
        {
            if(l.X == r.X)
            {
                return l.Y > r.Y;
             
                //if(l.Y > r.Y)
                //{
                //    return true;
                //} else
                //{
                //    return false;
                //}
            }
            return l.X > r.X;

            //else
            //{
            //    return l.X > r.X;
            //}
        }

        public static bool operator <(Point l, Point r)
        {
            if (l.X == r.X)
            {
                return l.Y > r.Y;
            }
            return l.X > r.X;

            
        }
        public override string ToString()
        {
            return $"({X}, {Y})";
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace D05_Task
{
    class Calculator_1
    {
        //set attributes
        int a, b;

        //set Constructor functions
        public Calculator_1(int _a, int _b)
        {
            a = _a;
            b = _b;
        }
        public Calculator_1(int _a) : this(_a, 0)
        {
            a = _a;

        }

        public Calculator_1()
        {
            a = 0;
            b = 0;
        }

        //set calc.Methods
        public static int Add(int _a, int _b)
        {
            return _a + _b;

        }
        
        public static int Substract (int _b, int _a)
        {
            return _a - _b;
        }

        public static int multiple(int _a, int _b)
        {
            return _a * _b;
        }

        public static float Divide(float _a, float _b)
        {
            if (_b != 0)
                return _a / _b;
            Console.WriteLine("Cannot Divide on ZERO!!");
            return _b / _a;
           
        }

    }
}

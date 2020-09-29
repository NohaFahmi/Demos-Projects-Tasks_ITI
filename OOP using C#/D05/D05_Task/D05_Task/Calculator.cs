using System;
using System.Collections.Generic;
using System.Text;

namespace D05_Task
{
    class Calculator
    {
        //set attributes
        int a, b;

        //set Constructor functions
        public Calculator(int _a, int _b)
        {
            a = _a;
            b = _b;
        }

        public Calculator(int _a):this(_a, 0)
        {
            a = _a;
            
        }

        public Calculator()
        {
            a = 0;
            b = 0;
        }

        //set calc.Methods

        public int Add()
        {
            return a + b;
        }

        public int Substract()
        {
            return a-b;
        }

        public  int Multiple()
        {
            return a *b;
        }

        public double Divide()
        {
            if(b == 0)
                return b/a ;
            return a/b;
        }


    }
}

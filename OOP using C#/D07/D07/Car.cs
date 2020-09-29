using System;
using System.Collections.Generic;
using System.Text;

namespace D07
{
    class Car
    {
        string model;
        int max;
        Engine carEngine;

        public Car(int _m, int _max)
        {
            carEngine = new Engine();
        }

        public Car(string _m, int _max, Engine _engine)
        {
            model = _m;
            max = _max;
            carEngine = _engine;
        }
    }
}

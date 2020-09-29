using System;

namespace D04_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Duration D1 = new Duration(9, 30, 30);

            Console.WriteLine(D1.ToString());

            Duration D = new Duration(33333);

            Console.WriteLine(D.ToString());
        }
    }
}

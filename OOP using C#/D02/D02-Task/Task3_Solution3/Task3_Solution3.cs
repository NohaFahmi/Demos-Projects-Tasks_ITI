using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace D02_Task_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK 3:
              //How can you count the occurrence of 1 from 1 to 99,999,999 (1 short of 100 million) 
            //and total up how many 1s were there.


            var watch = new System.Diagnostics.Stopwatch();



            #region Solution #3
            /*
             the number of 1s could be get by the eq:[(n) *(10) ^ (n + 1) ] +1, and n is the number of zeros in the 100, 000,000
            Ex: 100000000 >> n = 8
            */

            watch.Start();

            Console.WriteLine((8 * Math.Pow(10, 7)) + 1);

            watch.Stop();

            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms"); //26ms

            #endregion

        }
    }
}
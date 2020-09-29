using System;

namespace Task3_Solution1
{
    class Program
    {
        static void Main(string[] args)
        {


            //Task3: How can you count the occurrence of 1 from 1 to 99,999,999 (1 short of 100 million) 
            //and total up how many 1s were there.

            var watch = new System.Diagnostics.Stopwatch();

            int[] arr = new int[100000000];

            int count = 0;

            #region Solution #1

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += i + 1;
            }
            
            watch.Start();

            foreach (int num in arr)
            {
                string numToStr = num.ToString(); 

                for (int j = 0; j < numToStr.Length; j++)
                {
                    if (numToStr[j] == '1')
                    {
                        count += 1;
                    }
                }

            }

            Console.WriteLine(count);
            watch.Stop();

            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms"); //10110ms

            #endregion


        }
    }
}

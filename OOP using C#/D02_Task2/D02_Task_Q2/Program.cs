using System;
using System.Linq;

namespace D02_Task_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q.2>>

            //•	Given a list of space separated words, reverse the order of the words.

            string[] inputArr =
            {
                "This is Task 2",
                "Wish you Luck",
                "All your Base",
                "Word",
                "This is a Test"
            };

            foreach(string ele in inputArr)
            {
                string result = string.Join(" ", ele.Split(" ").Reverse());

                Console.WriteLine(result);
            }

            

            #endregion
        }
    }
}

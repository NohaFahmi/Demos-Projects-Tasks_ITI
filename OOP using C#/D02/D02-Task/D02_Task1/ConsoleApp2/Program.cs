using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            #region D02_Lab_Task
            #region Q.1>>


           
            //Your task will be to write a program find the longest distance between
            //Two equal cells.In this example.The distance is measured by the number Of cells- for example, 
            //the distance between the first and the fourth cell is 2(cell 2 and cell 3).


            //create array as input from user

            //int[] arr = { 3, 0, 3, 0, 5, 5, 7, 5, 0, 1, 5, 3 };
            int[] arr = new int[9];

            Console.WriteLine("Enter your Array Elements");
            for (int i =0; i< arr.Length; i++)
            {
                Console.WriteLine("Enter Element (" + (i+1) + "): ");
                int userInput = int.Parse(Console.ReadLine());
               
                arr[i] = userInput;
            }

            int Maximundistance = 0;
            int firstIndex = 0;
            int secondIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            { 

                for (int y = i + 1; y < arr.Length; y++)
                {
                    if (arr[i] == arr[y])
                    {
                        firstIndex = i;
                        secondIndex = y;

                        int dist = firstIndex > secondIndex ? firstIndex - secondIndex : secondIndex - firstIndex;

                        if (dist > Maximundistance)
                        {
                            Maximundistance = dist;
                            
                            
                        }
                        

                    }

                }

            }

            Console.WriteLine(Maximundistance-1);

            #endregion

            #endregion
        }
    }
}


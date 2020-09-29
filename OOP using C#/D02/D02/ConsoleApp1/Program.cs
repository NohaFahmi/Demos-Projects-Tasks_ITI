using System;
using System.ComponentModel;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Trenary Operators

            //string Ternary = 5 > 4 ? "it is Bigger" : "It is not!";

            //Console.WriteLine(Ternary);

            ////if-statement
            //#region ControlStatements

            //int grade = 60;

            //if (grade > 80)
            //{
            //    Console.WriteLine("Good");
            //}
            //else 
            //if (grade > 50)
            //{
            //    Console.WriteLine("Pass");
            //}
            //else
            //{
            //    Console.WriteLine("Fail");
            //}

            ////C# is stongly typed, so to compare variable it must be the same type and value!!

            //int month = 7;

            //if (month == 1)
            //    Console.WriteLine("Jun");
            //else if (month == 2)
            //    Console.WriteLine("Feb");
            //else if (month == 3)
            //    Console.WriteLine("March");

            ////Using switch case 
            //switch(month)
            //{
            //    case 1:
            //        Console.WriteLine("Jun");
            //        break;
            //    case 2:
            //        Console.WriteLine("Feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("March");
            //        break;
            //}

            //switch (month)
            //{
            //    case 7:
            //    case 8:
            //    case 1:
            //        Console.WriteLine("31");
            //        break;

            //    case 2:
            //        Console.WriteLine("28");
            //        break;

            //    case 4:
            //        Console.WriteLine("30");
            //        break;
            //}

            ////Looping 
            ////1. for loop:
            ////for(initial; condition; increment) {//code}
            ////the variable created into for loop, not accessible outside it
            ////increment is neccesary to avoid infinite loop

            //for(int i=0; i<10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            ////2. While loop:
            ////use it when you don't know the number of times you have to repeat the code!!
            ////it check the condition first and then 
            //int InputNum = int.Parse(Console.ReadLine()); //convert string to int
            ////while(InputNum > -1)
            ////{
            ////    Console.WriteLine(InputNum);
            ////    InputNum = int.Parse(Console.ReadLine());

            ////}

            ////3.do while 
            ////it excutes the code for one time at least before check the condition
            //do
            //{
            //    Console.WriteLine(InputNum);
            //    InputNum = int.Parse(Console.ReadLine());
            //}

            //while (InputNum > -1);

            //#endregion

            //#region Casting


            //int a = 5;
            //long b = 500;
            //b = a; // safe implicit

            //b = (long)a; // unsafe beacause overflow could happen

            //checked
            //{
            //    a = (int)b;
            //}

            //Console.WriteLine("Enter the Number");
            ////int userInput = int.Parse(Console.ReadLine());
            //string userInput = Console.ReadLine();
            ///*
            //if (int.TryParse(Console.ReadLine(), out userInput))
            //{
            //    Console.WriteLine("Ok");
            //}
            //*/


            //#endregion
            //

            #region String

            //string s = new string("");
            int x = 10;
            string s = " Hello/Noha/Welcome/ Back";

            //there are functions and attr could be excuted on strings

            //length is attr

            Console.WriteLine(s.Length);

            Console.WriteLine(s.ToLower());

            Console.WriteLine(s.ToUpper());

            Console.WriteLine(string.Concat("Hi, ", "Hello", " ", s, " Welcome to Our Coourse!!"));

            Console.WriteLine(s.IndexOf('l'));

            Console.WriteLine(s.Substring(5));
            Console.WriteLine(s.Substring(2, 5));


            string[] arrString = s.Split('/');
            for(int i=0; i<arrString.Length; i++)
            {
                Console.WriteLine(arrString[i]);
            }

            #endregion

            #region Arrays
            //arrays item must be from same type
            //it is a refernced data type
            //using for length
            //it could be 1D or 2D (this called Rank)

            #region 1D Arrays

            
            //int[] arr = new int[5]; //will save 5 places for arr items

            int[] arr = { 3, 55, 6, 7, 8, 98 };// another way to define arrays
            Console.WriteLine(arr.Rank);

            Console.WriteLine("======================");

            //To get last index of array

            Console.WriteLine(arr[^1]);
            Console.WriteLine(arr[^2]);
            Console.WriteLine(arr[^3]);

            Console.WriteLine("Range");
            // To spilit the array or some of it we use Range feature

            int[] r1 = arr[2..6];

            r1 = arr[..6];

            r1 = arr[2..];

            r1 = arr[3..^0];
            foreach(int item in r1)
            {
                Console.WriteLine(item);
            }

            //assign values to array indexes
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            //arr[3] = 4;

            Console.WriteLine("LOOOOOOOOPS ---------------");
            //to loop on array
            //2. foreach loop, it is readonly, can't change values inside it

            foreach (int item in arr)
            {
                Console.WriteLine(item);
                //item = 6;
            }

            Console.WriteLine("for loop ---------------");

            //1. for loop
            for (int i =0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                arr[arr.Length-1] = 150;
                
            }

            #endregion
            Console.WriteLine("2D Arrays -------------");
            #region 2D Arrays

            //int[,] marks = new int[3, 2]; // 3 cols and 2 rows

            int[,] marks = new int[3, 2]
            {
                {1, 2},
                {3,4},
                {5,6}
            };

            Console.WriteLine(marks.Rank);
            Console.WriteLine(marks.Length);
            //to get num of cols or rows (take 0 for cols and 1 for rows)
            Console.WriteLine(marks.GetLength(0));
            Console.WriteLine(marks.GetLength(1));

            //marks[0, 0] = 1;
            //marks[0, 1] = 2;
            //marks[0, 2] = 3;

            //To loop on 2D ??????

            #endregion

            #region Jagged Array

            int[][] jaggedArr = new int[3][]
            {
                new int [] {1},//creates one col in first row, creates an array on each row
                new int [] {3,4}, //creates two cols in first row
                new int [] {5,6}
            };
            #endregion

            #endregion
        }
    }
}
using System;
using System.Collections.Generic;

namespace Examination_System
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the Qustions&Answers List for Practice Exam

            List<Questions> PracticeQuestionsList = new List<Questions>()
            {
                new True_False(
                    " is C# a strong-typed language?",
                    10,
                    1,
                    new List<string>{ "A: True", "B: False"},
                    "B"
                ),
                new Choose(
                  "How do you insert COMMENTS in C# code?",
                  25,
                  2,
                  new List<string>{"A: // This is a comment", "B: # This is a comment", "C: /* This is a comment"},
                  "A"
                ),
                new True_False(
                    "is JavaScript a week-typed language?",
                    10,
                    3,
                    new List<string>{"A: True", "B: False"},
                    "A"
                ),
                new Choose(
                    "Which data type is used to create a variable that should store text?",
                    25,
                    4,
                    new List<string>{"A: myString", "B: string", "C: Txt"},
                    "B"
                )
            };

            //Create the Qustions&Answers List for Final Exam
            List<Questions> FinalQuestionsList = new List<Questions>()
            {
                new Choose(
                    "Inside which HTML element do we put the JavaScript?",
                    15,
                    1,
                    new List<string>{"A: <Scripting>", "B: <script>", "C: <js>"},
                    "B"
                ),
                 new Choose(
                    "How do you write \"Hello World\" in an alert box?",
                    15,
                    2,
                    new List<string>{"A: alert(\"Hello World\");", "B: msg(\"Hello World\");", "C: alertBox(\"Hello World\");"},
                    "A"
                ),
                 new Choose(
                    "How does a WHILE loop start?",
                    15,
                    3,
                    new List<string>{"A: while(i <= 10; i++)", "B: while i = 1 to 10", "C: while(i <= 10)"},
                    "C"
                ),
                 new Choose(
                    "Which operator is used to assign a value to a variable?",
                    15,
                    4,
                    new List<string>{"A: ===", "B: =", "C: =="},
                    "B"
                ),
                new True_False(
                    "The external JavaScript file must contain the <script> tag.",
                    5,
                    5,
                    new List<string>{ "A: True", "B: False"},
                    "B"
                ),
                new True_False(
                    "JavaScript is the same as Java.",
                    5,
                    6,
                    new List<string>{ "A: True", "B: False"},
                    "B"
                ),
                new True_False(
                    "Is JavaScript case-sensitive?",
                    5,
                    7,
                    new List<string>{ "A: True", "B: False"},
                    "A"
                )

            };

            //Program start
            Console.WriteLine("Choose: \n 1: Practice Exam \n 2: Final Exam");

            var input = Console.ReadLine();
            int examChoice;

            //checking if the user entering the right exam type
            while(!(int.TryParse(input, out examChoice)))
            {
                Console.WriteLine("Enter Numbers between 1 or 2 only!!");
                input = Console.ReadLine();
                
            }

            //Practice Exam
            if (examChoice == 1)
            {
                Practice p1 = new Practice();
                p1.ShowExam(PracticeQuestionsList);

                //create a list to contain the users answers
                List<string> answersList = new List<string>();

                //looping to get user answers
                for(int i=0; i < PracticeQuestionsList.Count; i++)
                {
                    string userAns = Console.ReadLine();

                    //checking if userAnswer is null
                    while (userAns == "")
                    {
                        Console.WriteLine("Choose between A, B or C");
                        userAns = Console.ReadLine();
                    }

                    //checking if userAnswer is not one of the options
                    while (!(userAns.ToLower() == "a" || userAns.ToLower() == "b" || userAns.ToLower() == "c"))
                    {
                        Console.WriteLine("Choose between A, B or C");
                        userAns = Console.ReadLine();

                    }

                    //store user answers into a list
                    answersList = p1.SaveUserAnswers(userAns);



                }
                //get the result of exam and show model answer
                p1.GetResults(PracticeQuestionsList, answersList);

            }

            //Final Exam
            else if (examChoice == 2)
            {
                Final f1 = new Final();
                f1.ShowExam(FinalQuestionsList);

                List<string> answersList = new List<string>();

                foreach (Questions q in FinalQuestionsList)
                {
                    string userAns = Console.ReadLine();

                    //checking if userAnswer is null
                    while (userAns=="")
                    {
                        Console.WriteLine("Choose between A, B or C");
                        userAns = Console.ReadLine();
                    }

                    //checking if userAnswer is not one of the options
                    while (!(userAns.ToLower() == "a" || userAns.ToLower() == "b" || userAns.ToLower() == "c"))
                    {
                        Console.WriteLine("Choose between A, B or C");
                        userAns = Console.ReadLine();

                    }
                    //store user answer into list
                    answersList = f1.SaveUserAnswers(userAns);
                }

                //get the results of the exam
                f1.GetResults(FinalQuestionsList, answersList);
            }

        }
    }
}

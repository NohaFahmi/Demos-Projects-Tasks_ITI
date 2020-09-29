using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_System
{
    abstract class Exam
    {
        //set attrs
        protected int time;
        protected int QCount;
        protected int type;
        protected int totalMarks;
        protected List<string> UserAns;
        
        // set ShowExam func to display all Questions
        abstract public void ShowExam(List<Questions> Qlist);

        //set SaveUserAnswers func to store the user's answers
        abstract public List<string> SaveUserAnswers(string _ans);

        //set the GetResults func to calc. the user's score and display it
        abstract public void GetResults(List<Questions> Qlist, List<string> _userAnsweres);
    
    }
    //creating an instance of Exam class
    class Practice: Exam
    {
        //set Constructors
        public Practice(int _t)
        {
            type = _t;
        }

        public Practice()
        {
            type = 1;
            QCount = 0;
            time = 10;
            totalMarks = 0;
            UserAns = new List<string>();
        }
        // func takes the Questions list and diplay it on screen
        public override void ShowExam(List <Questions> Qlist)
        {

            QCount = Qlist.Count;

            Console.WriteLine($"----Practice Exam----\nNumber of Qusetions: ({QCount})  Exam Time: {time} Minutes\n-----------------------");
          
            foreach(Questions q in Qlist)
            {
                q.DisplayQuestions();
                Console.WriteLine("___________________");
            }

            Console.WriteLine("End of Questions\nStart Write Your Answers below\n______________________");

        }

        //func takes the user's answer and store into a list
        public override List <string> SaveUserAnswers(string _ans)
        {
            UserAns.Add(_ans);
            
            return UserAns;
        }
        
        // func takes the Questions list and display the model answer after user finishes his answers:: only for practice Exam mode
        public void ShowResults(List<Questions> list)
        {

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"Qusetion No.({i + 1}): {list[i].GetModelAns()}");
            }

        }

        //func takes the questions list and user's answers list, then calculates the score, displays it, then displays the model answer
        public override void GetResults(List<Questions> Qlist, List<string> _userAnsweres)
        {
            int fullMark = 0;
            for(int i= 0; i < Qlist.Count; i++)
            {
                fullMark += Qlist[i].GetMarks();

               if (_userAnsweres[i].ToLower() == Qlist[i].GetModelAns().ToLower())
               {
                    totalMarks += Qlist[i].GetMarks();
               } else if(_userAnsweres[i].ToLower() != Qlist[i].GetModelAns().ToLower())
               {
                    totalMarks += 0;
               }

            }

            string result = (totalMarks >= 35) ? $"Well Done :)\nYou've Got {totalMarks} of {fullMark}" : $"Hard Luck :( \nYou've Got {totalMarks} of {fullMark}";

            Console.WriteLine(result);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Here are The Exam Model Answer:\n ----------------");
            ShowResults(Qlist);


        }
    }

    //creating an instance of Exam class
    class Final : Exam
    {

        //set Constructors
        public Final(int _t)
        {
            type = _t;
        }

        public Final()
        {
            type = 1;
            QCount = 0;
            time = 10;
            UserAns = new List<string>();


        }

        public override void ShowExam(List<Questions> Qlist)
        {

            QCount = Qlist.Count;

            Console.WriteLine($"----Final Exam----\n\nNumber of Qusetions: ({QCount})  Exam Time: {time} Minutes\n-----------------------");

            foreach (Questions q in Qlist)
            {
                q.DisplayQuestions();
                Console.WriteLine("___________________");
            }

            Console.WriteLine("End of Questions\n\nStart Writing Your Answers below:\n-----------------------------");

        }

        public override List<string> SaveUserAnswers(string _ans)
        {
            UserAns.Add(_ans);

            return UserAns;
        }

        //func takes the questions list and user's answers list, then calculates the score, and displays it.
        public override void GetResults(List<Questions> Qlist, List<string> _userAnsweres)
        {
            int fullMark = 0;

            for (int i = 0; i < Qlist.Count; i++)
            {
                fullMark += Qlist[i].GetMarks();

                if (_userAnsweres[i].ToLower() == Qlist[i].GetModelAns().ToLower())
                {
                    totalMarks += Qlist[i].GetMarks();
                }
                else if (_userAnsweres[i].ToLower() != Qlist[i].GetModelAns().ToLower())
                {
                    totalMarks += 0;
                }

            }

            string result = (totalMarks >= 35) ? $"Well Done :)\nYou've Got {totalMarks} of {fullMark}" : $"Hard Luck :( \nYou've Got {totalMarks} of {fullMark}";

            Console.WriteLine(result);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Examination_System
{

    abstract class Questions
    {
        //set attrs
        protected string Header { set; get; }
        protected string Body { set; get; }
        protected int QustionNo { set; get; }
        protected int Mark { set; get; }
        protected string ModelAns { set; get; }
        protected List<string> ChoicesList;
        
        //set getter func to get the model Answer
        public string GetModelAns()
        {
            return ModelAns;
        }
        //set a getter func to get the Question mark
        public int GetMarks()
        {
            return Mark;
        }

        //set an abstract func to display the Question
        abstract public void DisplayQuestions();

    }

    //creating an instance from Questions class
    class True_False : Questions
    {
        //set the constructor 
        public True_False(string _b, int _m, int _qNum, List <string> _choices, string _ans)
        {
            Header = "Choose True Or False";
            Body = _b;
            Mark = _m;
            QustionNo = _qNum;
            ChoicesList = _choices;
            ModelAns = _ans;
        }

        //displayQuestions func
        public override void DisplayQuestions()
        {
            Console.WriteLine($"{QustionNo}- {Header}: ({Mark} Marks)\n\n{Body}\n\n      {ChoicesList[0]}     {ChoicesList[1]}");
        }

    }

    //creating an instance from Questions class
    class Choose : Questions
    {
        //set the constructor
        public Choose(string _b, int _m, int _qNum, List<string> _choises, string _ans)
        {
            Header = "Choose One of the following Answers";
            Body = _b;
            Mark = _m;
            QustionNo = _qNum;
            ChoicesList = _choises;
            ModelAns = _ans;
  
        }
        //displayQuestions func
        public override void DisplayQuestions()
        {
            Console.WriteLine($"{QustionNo}- {Header}: ({Mark} Marks)\n\n{Body}\n\n   {ChoicesList[0]}     {ChoicesList[1]}     {ChoicesList[2]}");
        }

    }
}

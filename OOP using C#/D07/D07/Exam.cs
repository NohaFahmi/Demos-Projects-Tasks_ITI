using System;
using System.Collections.Generic;
using System.Text;

namespace D07
{
    class Exam
    {
        int id;
        int numOfQ;
        Question[] questions;

        public Exam()
        {
            questions = new Question[numOfQ];
        }

        public Exam(int _id, int _Qnum)
        {
            id = _id;
            numOfQ = _Qnum;
            questions = new Question[numOfQ];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace D03
{
 public  struct Employee
    {


        //attr
        //ctor
        //fun


        //internal int id;
        //public string name;
        //Private  double salary;

        //Attributs
        int ID;
        string name;
        double salary;

        
        

      //public  Employee()

        //public Employee(,)
        //{

        //}

        //Fun


//accessmodifier  returnDataType  FUnName(int var1, float var2,,,,,,)
        internal void setId(int _id)
        {
            if(_id>0)
                 ID = _id;
            else
                Console.WriteLine("Id Cannot be Negative");
        }

        public int GetId()
        {

            return ID;

        }

        public override string ToString()
        {
            return $"name{name } id={ID} salary={salary}";
        }




    }
}

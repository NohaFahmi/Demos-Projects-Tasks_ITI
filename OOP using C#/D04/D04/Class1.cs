using System;
using System.Collections.Generic;
using System.Text;

namespace D04
{
    //instead of repeating chars between classes
    //I could create a parent class
    //which holds the main attrs 
    //and then create child classes and inherits those attrs from it and we can only inherit from only one class

    class Point
    {

        //to make these data only accessible to the class that will inherit from this class
        //we can use access modifier: Protected
        protected int x;
        protected int y;

        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
    }
    class Car
    {

        //classes has 6 access modifier
        //default is Private
        //it better to be Private and that is called encapsulation
        
        //attributes

        string Model;
        int max;
        int Current;

        //adv of setters
        //it protect the variables from manipulation by other people
        //disAdv
        //the shape of it is not right and each var has to have a setter an getter which means alot of code!!!
        //the solution is to use Properties

        //constructor
        //once I created any constructor in my class, the auto-created constructor is deleted
        //it could be private, but I can't use it outside
        public Car(string _model, int _max, int _curr)
        {
            Model = _model;
            max = _max;
            Current = _curr;
        }
        public Car(int _max)
        {
            
            max = _max;

        }
        public Car(string _model, int _curr):this(50)
        {
            Model = _model;
            Current = _curr;
            //max = 30;
           
        }

        public Car(int _curr, int _max) : this("BMVV", _curr, _max)
        {
            
            Current = _curr;
            max = _max;

        }
        //Constructor Chaining: Calling constructor that take spec. params into another constructor
        public Car(): this("BmW", 123, 60) {} //Constructor Chaining


        //props
        public int MaxSpeed
        {
            get { return max; }
            //using internal makes users on same proj can set but not get
           //internal set
            set 
            { 
                //filtering data
                if(value> -1 && value<200)
                {
                    max = value;
                } else
                {
                    Console.WriteLine("Error!!");
                }
                
            }
        }

        
        //used to give initial values for vars when creating the object

        //set functions

        //set maxspeed
        //public void setMax(int _max)
        //{
        //    MaxSpeed = _max;
        //}

        //get Maxspeed

        // public int getMax()
        //{
        //    return max;
        //}
        //function to display data on screen
        public override string ToString()
        {
            return $"Model {Model} Max {MaxSpeed} current {Current}";

        }
    }
}

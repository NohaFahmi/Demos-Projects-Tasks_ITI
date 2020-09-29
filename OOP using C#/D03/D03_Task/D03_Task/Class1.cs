using System;
using System.Collections.Generic;
using System.Text;

namespace D03_Task
{
    struct HiringDate
    {
        int year;
        string month;
        int day;

        string fullDate;

        //set functions
        
        
        //set month 
        public void setMonth (string _m)
        {
            month = _m;
           
        }

        //set Year
        public void setYear(int _y)
        {
            
            if (_y >= 1900 && _y <= 2020)
            {
                year = _y;
            }
            else
            {
                Console.WriteLine("Year must be between 1990 & 2020");
            }

        }
        //set Day
        public void setDay (int _d)
        {

            if (_d >= 1 && _d <= 31)
            {
                day = _d;
            }
            else
            {
                Console.WriteLine("Days must be between 1 & 31");
            }
        }
       
        //Get the Date
        public int getYear()
        {
            return year;
        }

        public string getMonth()
        {
            return month;
        }

        public int getDay()
        {
            return day;
        }

        //getFullDate
        public string getFullDate()
        {
            fullDate = $"[{day}-{month}-{year}]";
            return fullDate;
        }

    }
    enum GenderTypes
    {
        F,
        M,
        None

    }

    struct Employees
    {
        //setting Attrs
        
        
        int ID;
        double salary;
        GenderTypes Gender;
        HiringDate HireDate;

        //setting functions
        //1.1 set ID
        public void setId(int _id)
        {
            ID = _id;
        }

        //1.2 Get ID 
        public int getId()
        {
            return ID;
        }

        //2.1 set salary 
        public void setSalary(double _salary)
        {
            salary = _salary;

        }

        //2.2 get salary

        public double getSalary()
        {
            return salary;
        }

        //3.1 setHDate 
        public void setHireDate(int _y, string _m, int _d)
        {
            HireDate.setDay(_d);
            HireDate.setMonth(_m);
            HireDate.setYear(_y);
        }

        //3.2 Get HireDate
        public HiringDate getHDate()
        {
            return HireDate;
        }

        
        //4.1 set Gender
        public void setGender(GenderTypes _gender)
        {
            Gender = _gender;
        }

        //4.2 getGender

        public GenderTypes getGender()
        {
            return Gender;
        }

    }



}

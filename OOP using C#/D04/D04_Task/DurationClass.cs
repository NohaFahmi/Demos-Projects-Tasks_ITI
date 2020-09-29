using System;
using System.Collections.Generic;
using System.Text;

namespace D04_Task
{
    class Duration
    {
        //set attributs

        int hours;
        int minutes;
        int seconds;

        //set constructor
        public Duration(int _h, int _m, int _s)
        {
            hours = _h;
            minutes = _m;
            seconds = _s;
        }
        public Duration (int _s):this(0, 0, _s)
        {
            //3600
            //3600/60 = 60
            if(_s > 60)
            {
                hours += _s / (60*60);
                if(_s % (60* 60) != 0)
                {
                    minutes += (_s - (hours * 60 * 60)) / 60;
                    seconds = _s - (hours * 3600 + minutes * 60);
                } else
                {
                    seconds = 0;
                }
                
            }

        }

        //set override ToString
        public override string ToString()
        {
            if(hours == 0)
            {
                return $"Output>> \nMinutes: {minutes}, Seconds: {seconds}";
            }
            return $"Output>> \nHours: {hours}, Minutes: {minutes}, Seconds: {seconds}";

        }


    }

    
}

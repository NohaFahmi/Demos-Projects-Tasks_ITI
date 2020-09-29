using System;
using System.Collections.Generic;
using System.Text;

namespace D06
{
    interface ISeries
    {
        //this interface is like a code contract, it makes our code 
        int GetNext();//function that get the next element in series

        void Reset(); //reset the initial values


    }
}

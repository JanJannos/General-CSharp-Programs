using System;
using System.Collections.Generic;
using System.Text;

namespace EventsObserver
{
    public class Subscriber1                //1st subscriber class
    {
        public void Subscribe(Publisher m)  //get the object of pubisher class
        {
            m.Tick += HeardIt;              //attach listener class method to publisher class delegate object
        }
        private void HeardIt(Publisher m, EventArgs e)   //subscriber class method
        {
            System.Console.WriteLine("Heard It by Listener");
        }

    }

    public class Subscriber2                   //2nd subscriber class
    {
        public void Subscribe2(Publisher m)    //get the object of pubisher class
        {
            m.Tick += HeardIt;               //attach listener class method to publisher class delegate object
        }
        private void HeardIt(Publisher m, EventArgs e)   //subscriber class method
        {
            System.Console.WriteLine("Heard It by Listener2");
        }

    }
}

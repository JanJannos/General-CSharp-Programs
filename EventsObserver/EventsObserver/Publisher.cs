using System;
using System.Collections.Generic;
using System.Text;

namespace EventsObserver
{
    public class Publisher //main publisher class which will invoke methods of all subscriber classes
    {
        //declaring a delegate
        public delegate void TickHandler(Publisher m, EventArgs e); 
        public TickHandler Tick;     //creating an object of delegate
        public EventArgs e = null;   //set 2nd paramter empty
        public void Start()     //starting point of thread
        {
            while (true)
            {
                System.Threading.Thread.Sleep(300);
                if (Tick != null)   //check if delegate object points to any listener classes method
                {
                    Tick(this, e);  //if it points i.e. not null then invoke that method!
                }
            }
        }
    }
}

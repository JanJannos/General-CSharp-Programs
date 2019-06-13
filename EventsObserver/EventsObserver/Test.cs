using System;

namespace EventsObserver
{
    class Test
    {
        static void Main()
        {
            Publisher m = new Publisher();      //create an object of publisher class which will later be passed on subscriber classes
            Subscriber1 l = new Subscriber1();  //create object of 1st subscriber class
            Subscriber2 l2 = new Subscriber2(); //create object of 2nd subscriber class
            l.Subscribe(m);     //we pass object of publisher class to access delegate of publisher class
            l2.Subscribe2(m);   //we pass object of publisher class to access delegate of publisher class

            m.Start();          //starting point of publisher class
        }
    }
}

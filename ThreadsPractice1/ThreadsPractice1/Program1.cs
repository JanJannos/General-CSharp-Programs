using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;



namespace ThreadsPractice1
{
    class Program1
    {
        // ----- Simple Thread Example -----
        static void Main1(string[] args)
        {
            // Create a thread and start it
            Thread t = new Thread(Print1);
            t.Start();

            // This code will run randomly
            for (int i = 0; i < 1000; i++)
                Console.Write(0);

            Console.ReadLine();

        }

        static void Print1()
        {
            for (int i = 0; i < 1000; i++)
                Console.Write(1);
        }
    }
}

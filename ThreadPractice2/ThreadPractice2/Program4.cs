using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace ThreadPractice2
{
    class Program4
    {
        static Queue<int> numbers = new Queue<int>();
        static Random rand = new Random();
        const int NUM_THREADS = 3;
        static int[] sums = new int[NUM_THREADS];
        static void ProduceNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                numbers.Enqueue(rand.Next(10));
                Thread.Sleep(rand.Next(1000));
            }

        }

        static void SumNumbers(object threadNumber)
        {
            DateTime startTime = DateTime.Now;
            int mySum = 0;
            while ((DateTime.Now - startTime).Seconds < 11)
            {
                if (numbers.Count != 0)
                {
                    mySum += numbers.Dequeue();
                }
            }
            sums[(int)threadNumber] = mySum;
        }

        static void Main()
        {

      
        }
    }
}

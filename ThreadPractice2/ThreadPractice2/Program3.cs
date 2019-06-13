using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;


// Based of this Video
// https://www.youtube.com/watch?v=0v8sDF58mME&list=PLRwVmtr-pp06KcX24ycbC-KkmAISAFKV5&index=10

namespace ThreadPractice2
{

    class Program2
    {
        static byte[] vals = new byte[500000000];
        static long[] portionResults;
        private static long portionSize;

        static void GenerateInts()
        {
            Console.WriteLine("Generating...");
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var rand = new Random();
            for (int i = 0; i < vals.Length; i++)
            {
                vals[i] = (byte)rand.Next(1000);
            }
            watch.Stop();
            Console.WriteLine("Generating Time: {0}", watch.Elapsed);

        }


        static void SumPortion(object portionNumber)
        {
            long sum = 0;
            int portionNumberRound = (int)portionNumber;
            for (long i = portionNumberRound * portionSize; i < portionNumberRound * portionSize + portionSize; i++)
            {
                sum += vals[i];
            }

            portionResults[portionNumberRound] = sum;
        }


        static void Main1()
        {

            portionResults = new long[Environment.ProcessorCount];
            portionSize = vals.Length / Environment.ProcessorCount;
            GenerateInts();
            Console.WriteLine("Summing...");
            Stopwatch watch = new Stopwatch();
            watch.Start();
            long total1 = 0;
            for (int i = 0; i < vals.Length; i++)
            {
                total1 += vals[i];
            }

            watch.Stop();
            Console.WriteLine("Total: {0}", total1);
            Console.WriteLine("Summing Time: {0}", watch.Elapsed);


            // From here with THREADS
            watch.Reset();
            watch.Start();

            Thread[] threads = new Thread[Environment.ProcessorCount];
            for (int i = 0; i < Environment.ProcessorCount ; i++)
            {
                threads[i] = new Thread(SumPortion);
                threads[i].Start(i);
            }


            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                threads[i].Join(); // Wait for all the threads to get done
            }

            long total2 = 0;
            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                total2 += portionResults[i];
            }

            watch.Stop();
            Console.WriteLine("Now summing with threads ... Total: {0}", total2);
            Console.WriteLine("Threading ... Summing Time: {0}", watch.Elapsed);
        }

    }
}

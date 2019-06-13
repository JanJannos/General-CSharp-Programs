//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Text;

//namespace ThreadPractice2
//{
//    class Program2
//    {
//        static byte[] vals = new byte[500000000];
//        static void GenerateInts()
//        {
//            Console.WriteLine("Generating...");
//            Stopwatch watch = new Stopwatch();
//            watch.Start();
//            var rand = new Random();
//            for (int i = 0; i < vals.Length; i++)
//            {
//                vals[i] = (byte)rand.Next(1000);
//            }
//            watch.Stop();
//            Console.WriteLine("Generating Time: {0}", watch.Elapsed);

//        }


//        static void Main()
//        {
//            GenerateInts();
//            Console.WriteLine("Summing...");
//            Stopwatch watch = new Stopwatch();
//            watch.Start();
//            long total = 0;
//            for (int i = 0; i < vals.Length; i++)
//            {
//                total += vals[i];
//            }
            
//            watch.Stop();
//            Console.WriteLine("Total: {0}", total);
//            Console.WriteLine("Summing Time: {0}", watch.Elapsed);
//        }

//    }
//}

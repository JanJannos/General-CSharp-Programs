using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadsPractice1
{
    class BankAcct
    {
        private Object acctLock = new Object();
        double Balance { get; set; }
        string Name { get; set; }

        public BankAcct(double bal)
        {
            Balance = bal;
        }

        public double Withdraw(double amt)
        {
            if ((Balance - amt) < 0)
            {
                Console.WriteLine($"Sorry ${Balance} in Account");
                return Balance;
            }

            lock (acctLock)
            {
                if (Balance >= amt)
                {
                    Console.WriteLine("Removed {0} and {1} left in Account",
                    amt, (Balance - amt));
                    Balance -= amt;
                }

                return Balance;

            }
        }

        // You can only point at methods
        // without arguments and that return 
        // nothing
        public void IssueWithdraw()
        {
            Withdraw(1);
        }
    }


    class Program2
    {


        // ----- Sleep Example -----

        // With sleep() the thread is suspended
        // for the designated amount of time
        static void Main2(string[] args)
        {
            int num = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(num);

                // Pause for 1 second
                Thread.Sleep(1000);

                num++;
            }

            Console.WriteLine("Thread Ends");

            Console.ReadLine();
        }
    }
}

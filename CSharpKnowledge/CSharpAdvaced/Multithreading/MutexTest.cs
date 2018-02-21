using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace CSharpAdvanced.Multithreading
{
    class MutexTest
    {
        // Mutex (mutual exclusion) object is used to synchronise access to a protected resource.
        // Mutex scope is system-wide, while the monitor's scope and lock's scope is application-wide.
        private static Mutex mut = new Mutex();

        public static void test()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread newThread = new Thread(new ThreadStart(delegate ()
                {
                    for (int d = 0; d < 2; d++)
                    {
                        UseResource();
                    }
                }));
                newThread.Name = String.Format("(Thread no. {0})", i + 1);
                newThread.Start();
            }
        }

        private static void UseResource()
        {
            Console.WriteLine("{0} is requesting the mutex", Thread.CurrentThread.Name);
            mut.WaitOne();

            Console.WriteLine("{0} has entered the critical section", Thread.CurrentThread.Name);
            Thread.Sleep(10000);
            Console.WriteLine("{0} is leaving the critical section", Thread.CurrentThread.Name);

            mut.ReleaseMutex();
            Console.WriteLine("{0} has released the mutex", Thread.CurrentThread.Name);
        }
    }
}

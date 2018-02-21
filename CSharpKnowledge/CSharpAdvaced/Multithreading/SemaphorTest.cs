using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CSharpAdvanced.Multithreading
{
     
    class SemaphorTest
    {
        private static Semaphore semaphore = new Semaphore(2, 2);
        public static void test( )
        {
            for (int i = 0; i < 3; i++)
            {
                Thread newThread = new Thread(new ThreadStart(delegate ()
                {
                    for (int d = 0; d < 1; d++)
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
            Console.WriteLine("{0} is requesting to enter", Thread.CurrentThread.Name);
            semaphore.WaitOne();

            Console.WriteLine("{0} has entered the critical section", Thread.CurrentThread.Name);
            Thread.Sleep(10000);
            Console.WriteLine("{0} is leaving the critical section", Thread.CurrentThread.Name);

            semaphore.Release();
            Console.WriteLine("{0} has left the critical section", Thread.CurrentThread.Name);
        }
    }
}

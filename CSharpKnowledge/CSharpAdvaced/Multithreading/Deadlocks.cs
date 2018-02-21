using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CSharpAdvanced.Multithreading
{

    class Deadlocks
    {
        public static void test()
        {
            // https://en.wikipedia.org/wiki/Deadlock
            // https://en.wikipedia.org/wiki/Critical_section
            // https://en.wikipedia.org/wiki/Mutual_exclusion

            //Lock - method/code block
            {
                Files file = new Files();
                Thread[] threads = new Thread[10];

                for (int i = 0; i < 10; i++)
                {
                    threads[i] = new Thread(new ParameterizedThreadStart(file.Write));
                    threads[i].Start($"c:\\accounts{i}.txt");
                }
            }

            //Monitor - specific resource
            {
                Files2 file = new Files2();
                Thread[] threads = new Thread[10];

                for (int i = 0; i < 10; i++)
                {
                    threads[i] = new Thread(new ParameterizedThreadStart(file.Write));
                    threads[i].Start($"c:\\accounts{i}.txt");
                }
            }
        }
    }

    class Files
    {
        public Object thisLock = new Object();
        public void Write(object path)
        {
            lock (thisLock)
            {
                // some logic of writing in files goes in where
                Console.WriteLine("[LOCK version] Writing in " + path);
                Thread.Sleep(2000);
                Console.WriteLine("[LOCK version] Writing process has been completed");
            }
        }

        public void Read(object path)
        {
            lock (thisLock)
            {
                // some logic of writing in files goes in where
                Console.WriteLine("[LOCK version] Reading from " + path);
                Thread.Sleep(1000);
                Console.WriteLine("[LOCK version] Reading process has been completed");
            }
        }
    }
    class Files2
    {
        public void Write(object path)
        {
            Monitor.Enter(path);
            try
            {
                // some logic of writing in files goes in where
                Console.WriteLine("[MONITOR version] Writing in " + path);
                Thread.Sleep(2000);
                Console.WriteLine("[MONITOR version] Writing process has been completed");
            }
            finally
            {
                Monitor.Exit(path);
            }
        }

        public void Read(object path)
        {
            Monitor.Enter(path);
            try
            {
                // some logic of writing in files goes in where
                Console.WriteLine("[MONITOR version] Reading from " + path);
                Thread.Sleep(1000);
                Console.WriteLine("[MONITOR version] Reading process has been completed");
            }
            finally
            {
                Monitor.Exit(path);
            }
        }
    }
}

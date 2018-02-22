using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CSharpAdvanced.Multithreading
{
    class ListOfThreads
    {
        public static void test()
        {
            SayHi hi = new SayHi(); string name = "Ahmad"; int count = 2;
            List<Thread> listofThreads = new List<Thread>();

            listofThreads.Add(new Thread(new ThreadStart(() => hi.SayHiEnglish(name, count))));
            listofThreads.Add(new Thread(new ThreadStart(() => hi.SayHiKorean(name, count))));
            listofThreads.Add(new Thread(new ThreadStart(() => hi.SayHiFrench(name, count))));
            listofThreads.Add(new Thread(new ThreadStart(() => hi.SayHiGreek(name, count))));
            listofThreads.Add(new Thread(new ThreadStart(() => hi.SayHiHindi(name, count))));
            listofThreads.Add(new Thread(new ThreadStart(() => hi.SayHiRussian(name, count))));
            listofThreads.Add(new Thread(new ThreadStart(() => hi.SayHiSwedish(name, count))));

            foreach (var thread in listofThreads)
            {
                thread.Start();
            }
        }
    }

    class SayHi
    {
        public void SayHiEnglish(string name, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Hi " + name);
            }
        }

        public void SayHiKorean(string name, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Annyeong " + name);
            }
        }
        public void SayHiFrench(string name, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Salut " + name);
            }
        }

        public void SayHiGreek(string name, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Geia " + name);
            }
        }

        public void SayHiHindi(string name, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Namaste " + name);
            }
        }

        public void SayHiRussian(string name, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Zdravstvuy " + name);
            }
        }

        public void SayHiSwedish(string name, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Hej " + name);
            }
        }
    }
}

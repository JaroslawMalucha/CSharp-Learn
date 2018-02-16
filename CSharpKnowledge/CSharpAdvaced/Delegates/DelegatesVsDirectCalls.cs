using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.Delegates
{
    public delegate void DoSomethingDelegate();

    class DelegatesVsDirectCalls
    {
        public static void test()
        {
            System.Diagnostics.Stopwatch watchOne = new System.Diagnostics.Stopwatch();
            System.Diagnostics.Stopwatch watchTwo = new System.Diagnostics.Stopwatch();
            DoSomethingDelegate taskOne = new DoSomethingDelegate(DoSomething);

            // Using delegates 
            Console.WriteLine("Delegate Method \n--------------");
            watchOne.Start();
            taskOne();
            watchOne.Stop();
            var elapsedOne = watchOne.Elapsed;
            Console.WriteLine(Math.Round(elapsedOne.TotalSeconds, 2));

            // Using direct calls
            Console.WriteLine("\nDirect Method\n--------------");
            watchTwo.Start();
            DoSomething();
            watchTwo.Stop();
            var elapsedTwo = watchTwo.Elapsed;
            Console.WriteLine(Math.Round(elapsedTwo.TotalSeconds, 2));

            Console.WriteLine("\nDelegates saved you " + Math.Round((elapsedTwo.TotalMilliseconds - elapsedOne.TotalMilliseconds), 4) + " milliseconds ");
            Console.WriteLine("Delegates saved you " + Math.Round((elapsedTwo.TotalSeconds - elapsedOne.TotalSeconds), 4) + " seconds ");
        }

        public static void DoSomething()
        {
            double number = 8.543231;
            List<double> list = new List<double>();
            for (double i = 0; i < 600_000; i++)
            {
                number += i + DateTime.Now.Second;
                list.Add(number);
            }
            list.Reverse();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace CSharpAdvanced.ClassesExercises
{
    class StopwatchDotNet
    {
        public static void test()
        {
            System.Diagnostics.Stopwatch t = new System.Diagnostics.Stopwatch();

            t.Start();
            Thread.Sleep(1000); // pauses execution, might freeze UI, no CPU usage
            t.Stop();
            Console.WriteLine(t.ElapsedMilliseconds);
            Console.WriteLine(t.Elapsed.Milliseconds); //remainder miliseconds (full seconds dropped)
            Console.WriteLine(t.Elapsed.TotalMilliseconds); //total miliseconds
            Console.WriteLine(t.Elapsed.TotalMinutes);

            t.Start();
            Thread.SpinWait(100000 * 10000); // runs meaningless instruction for CPU usage
            t.Stop();
            Console.WriteLine(t.ElapsedMilliseconds);
            Console.WriteLine(t.Elapsed.TotalMinutes);
        }
    }
}

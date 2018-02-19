using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CSharpAdvanced.MeasuringTime
{
    class Timer
    {
        public static void test()
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Elapsed += OnEachSecond;
            timer.Interval = 1000;
            timer.Enabled = true;

            Console.WriteLine("Press (x) to exit");
            while (Console.Read() != 'x') ;

        }

        private static void OnEachSecond(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("tick tock: " + DateTime.Now.ToLongTimeString());
        }
    }
}

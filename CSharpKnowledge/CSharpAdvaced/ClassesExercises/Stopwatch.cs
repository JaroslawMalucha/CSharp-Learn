using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CSharpAdvanced
{
    class Stopwatch
    {
        //private System.Diagnostics.Stopwatch timerCheat; // ; D
        private bool isRunning = false;
        private DateTime _startedAt;
        private TimeSpan _elapsed;
        private List<TimeSpan> _laps;
        private bool _started = false;

        public void Start()
        {
            if (isRunning)
                throw new Exception("Cannot start an already running timer. Please use Restart method.");
            Restart();
        }

        public void Stop()
        {
            if (isRunning)
            {
                _elapsed = Elapsed();
                isRunning = false;
            }
        }

        private void Restart()
        {
            _elapsed = TimeSpan.FromMilliseconds(0);
            _startedAt = DateTime.Now;
            isRunning = true;
            _started = true;
        }

        public void Reset()
        {
            _laps = new List<TimeSpan>();
            _elapsed = TimeSpan.FromMilliseconds(0);
            _startedAt = DateTime.MinValue;
            isRunning = false;
            _started = false;
        }

        public TimeSpan Elapsed()
        {
            if (isRunning)
                return DateTime.Now - _startedAt;
            else
                return _elapsed;
        }

        public List<TimeSpan> Laps()
        {
            return _laps;
        }
        public TimeSpan Laps(int oneBasedIndex)
        {
            // Assert
            if (oneBasedIndex < 1)
                throw new Exception("oneBasedIndex is 1 based");
            if (_laps.Count == 0)
            {
                if (isRunning)
                    throw new Exception("No Laps registered yet. First lap is still in progress...");
                else
                    throw new Exception("No Laps registered yet. Better start running :)");
            }
            else if (oneBasedIndex > _laps.Count)
                throw new IndexOutOfRangeException("Lap index does not exist. We dont know if you ever want to even start it lol.");
            else if (oneBasedIndex == _laps.Count)
                throw new IndexOutOfRangeException("Cannot return current lap time. Its still in progress...");

            // Process
            return _laps[oneBasedIndex];
        }

        public void NewLap()
        {
            if (_started)
            {
                Stop();
                _laps.Add(Elapsed());
                Start();
            }
            else
                Start();
        }




        public static void testStopwatch()
        {
            var timer = new Stopwatch();
            timer.Start();
            Thread.Sleep(1000);
            Console.WriteLine(timer.Elapsed().Seconds);
            timer.Stop();
            Console.WriteLine(timer.Elapsed().Seconds);
            timer.Stop();
            Console.WriteLine(timer.Elapsed().Seconds);
            timer.Start();
            try
            {
                timer.Start();
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot start a running timer.");
            }

            Console.WriteLine(timer.Elapsed().Seconds);

            timer.Reset();
            Console.WriteLine(timer.Elapsed().Seconds);

            timer.NewLap();
            Console.WriteLine(timer.Elapsed());
            timer.NewLap();
            timer.NewLap();
            Console.WriteLine(timer.Laps().Count);
            Console.WriteLine(timer.Laps(1).Seconds);
            try
            {
                Console.WriteLine(timer.Laps(2).Seconds);
            }
            catch (Exception)
            {
                Console.WriteLine("Lap not present");
            }
        }
    }
}

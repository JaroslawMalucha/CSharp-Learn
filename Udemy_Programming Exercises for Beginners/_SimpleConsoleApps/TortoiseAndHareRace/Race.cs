using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TortoiseAndHareRace
{
    public class Race
    {
        private Track _track;
        private bool _raceOver;

        public Race()
        {
            _track = new Track();
            new Tortoise(0, 0, "Tortoise");
            new Hare(0, 1, "Hare");
            new Pavol(0, 2, "Pavol");
            _raceOver = false;
        }

        public void Racing()
        {
            SetUpRace();

            do
            {
                Console.ReadLine();
                Console.Clear();
                _track.DisplayRaceTrack();
                foreach(var runner in Runner.AllRunners)
                {
                    Console.WriteLine(runner.MoveDescription);
                    runner.CalculateMove();
                    _track.RunnerPostition(runner);

                    if (runner.IsWinner(runner))
                        _raceOver = true;
                }
            } while (!_raceOver);

            Console.Clear();
            _track.DisplayRaceTrack();
            GetPlace();

        }

        private void SetUpRace()
        {
            foreach(var runner in Runner.AllRunners)
            {
                _track.RunnerPostition(runner);
            }
            Console.WriteLine("Welcome to the ultimate race!! Press any key to continue!");
        }

        public void GetPlace()
        {
            foreach (var runner in Runner.AllRunners.Where(
                x => x.CurrentPosition == Track.TrackLength))
            {
                Console.WriteLine($"The winner(s) is: {runner.Name}");
            }
        }


    }
}

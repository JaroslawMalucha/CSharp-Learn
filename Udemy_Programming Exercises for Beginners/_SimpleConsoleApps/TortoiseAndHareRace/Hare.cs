using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TortoiseAndHareRace
{
    public class Hare : Runner
    {
        public Hare(int currentPostition, int lane, string name)
        {
            CurrentPosition = currentPostition;
            Lane = lane;
            Name = name;
            MoveDescription = $"{Name} is READY! SET! GO!";
            AllRunners.Add(this);
            RunnerSymbol = "H";
        }

        public override void CalculateMove()
        {
            var move = GetMoveType();

            if (move >= 1 && move <= 20)
            {
                MakeMove(MoveType.Sleep);
                MoveDescription = $"{Name} is Sleeping (0)";
            }
            else if (move >= 21 && move <= 40)
            {
                MakeMove(MoveType.BigHop);
                MoveDescription = $"{Name} made a BigHop (+9)";
            }
            else if (move >= 41 && move <= 50)
            {
                MakeMove(MoveType.BigSlip);
                MoveDescription = $"{Name} made a Big Slip (-12)";
            }
            else if (move >= 51 && move <= 80)
            {
                MakeMove(MoveType.SmallHop);
                MoveDescription = $"{Name} made a Small Hop (+1)";
            }
        }
    }
}

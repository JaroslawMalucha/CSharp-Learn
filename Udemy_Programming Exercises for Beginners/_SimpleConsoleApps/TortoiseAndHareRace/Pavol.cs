using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TortoiseAndHareRace
{
    public class Pavol : Runner
    {
        public Pavol(int currentPostition, int lane, string name)
        {
            CurrentPosition = currentPostition;
            Lane = lane;
            Name = name;
            MoveDescription = $"{Name} is READY! SET! GO!";
            AllRunners.Add(this);
            RunnerSymbol = "P";
        }

        public override void CalculateMove()
        {
            var move = GetMoveType();

            if (move >= 1 && move <= 50)
            {
                MakeMove(MoveType.PavolJump);
                MoveDescription = $"{Name} made Pavol Jump (+5)";
            }
            else if (move >= 51 && move <= 70)
            {
                MakeMove(MoveType.Slip);
                MoveDescription = $"{Name} Slipped (-6)";
            }
            else
            {
                MakeMove(MoveType.SlowPlod);
                MoveDescription = $"{Name} moved Slow Plod (+1)";
            }
        }
    }
}

/*
IT 1050 Assignment 5
“Almost Chess”
Instructions:
Print a 2-Dimensional Chessboard
Continually ask the user for coordinates
Always overwrite the destination with the target
Always replace the target with an empty string
End the program if any of the coordinates are out of range
Technical Requirements
The board must actually be a 2-Dimensional Array of strings.
The board you display must be a true representation of the 2D Array.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050Assignment5_AlmostChess
{
  class Program
  {
    static void Main(string[] args)
    {
      ChessBoard chessBoard = new ChessBoard();
      chessBoard.displayChessBoard();
    }
  }
}

/*
Write an application that creates and returns a one-dimensional array containing
all the elements in the two-dimensional array. Store the values in a row major
format. For testing purposes, you may do a compile-time initialization of a 12 x 5
two-dimensional array. Display both the two-dimensional and the one dimensional
array. Be sure the values in the array are number aligned.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_TwoDimensionalArrays
{
  class Program
  {
    static void Main(string[] args)
    {
      int[,] twoDimensionalArray = new int[12, 5];
      int[] oneDimensionalArray = new int[twoDimensionalArray.Length];
      Random rand = new Random();
      int counter = 0;

      for (int r = 0; r < 12; r++)
      {
        for (int c = 0; c < 5; c++)
        {
          twoDimensionalArray[r, c] = rand.Next(0, 101);
          oneDimensionalArray[counter] = twoDimensionalArray[r, c];
          counter++;
        }
      }

      Console.WriteLine("Two Dimensional Array...");
      for (int r = 0; r < 12; r++)
      {
        for (int c = 0; c < 5; c++)
        {
          Console.Write(twoDimensionalArray[r, c] + " ");
        }
        Console.Write("\n");
      }

      Console.WriteLine("One Dimensional Array...");
      for (int i = 0; i < oneDimensionalArray.Length; i++)
      {
        if (i % 5 == 0)
          Console.Write("\n");

        Console.Write(oneDimensionalArray[i] + " ");
      }
    }
  }
}

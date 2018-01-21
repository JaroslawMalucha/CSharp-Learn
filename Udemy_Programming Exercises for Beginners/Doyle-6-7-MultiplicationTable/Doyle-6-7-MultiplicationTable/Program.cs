/*
Write a program that produces a multiplication table with 25 rows of computations.
Allow the user to input the first and last base values for the
multiplication table. Display a column in the table beginning with the first
base inputted value. The last column should be the ending base value entered.
The first row should be for 1 times the beginning base, 1 times the (beginning
base value + 1), through 1 times the ending base value. The last row should
be for 25 times the beginning base, 25 times the (beginning base value + 1),
through 25 times the ending base value. Base values can range from 2 through
8. Display an error message if an invalid base is entered. Display an aesthetically
formatted multiplication table. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doyle_6_7_MultiplicationTable
{
  class Program
  {
    static void Main(string[] args)
    {
      int beginningValue;
      int endValue;

      do
      {
        Console.Write("Please enter beginning base value: ");
        beginningValue = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter ending base value: ");
        endValue = Convert.ToInt32(Console.ReadLine());

        if (beginningValue < 2 || endValue > 8)
          Console.WriteLine("Invalid Input");
      } while (beginningValue < 2 || endValue > 8);

      Console.WriteLine("\n");

      //headers
      for (int i = beginningValue - 1; i <=endValue; i++)
      {
        if (i == beginningValue - 1)
          Console.Write(String.Format("{0,6}", "n"));
        else
          Console.Write(String.Format("{0,6}", i));
      }

      Console.WriteLine("\n");

      for (int i = 1; i <=25; i++) //rows
      {
        Console.Write(String.Format("{0,6}",i));
        for (int b = beginningValue; b <= endValue; b++)// collumns
        {
          string output = String.Format("{0,6}", i * b);
          Console.Write(output);
        }
        Console.WriteLine("");
      }
    }
  }
}

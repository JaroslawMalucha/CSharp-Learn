/*
Write a program that uses array and that allows any number of values between 0 and 10 to be
entered. When the user stops entering values, display a frequency distribution
bar chart. Use asterisks to show the number of times each value was entered. If a
given number is not entered, no asterisks should appear on that line. Your
application should display error messages if a value outside the acceptable range
is entered or if a non-numeric character is entered. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doyle_7_9_Chart
{
  class Program
  {
    static void Main(string[] args)
    {
      bool validInput = false;
      string input;
      int result;
      bool stopInput = false;
      string allInput = "";

      while(!stopInput)
      {
        do
        {
          validInput = false;
          Console.WriteLine("Please enter a number between 0 and 10 OR enter Q to exit program");
          input = Console.ReadLine();

          if (int.TryParse(input, out result))
          {
            if(result > 0 && result < 10)
            {
              validInput = true;
              allInput += input + ",";
            }
          }

          if (input.ToUpper().Equals("Q"))
          {
            validInput = true;
            stopInput = true;
          }

          if (!validInput)
            Console.WriteLine("Invalid Input. The value won't be counted");
        } while (!validInput);
      }

      string[] numbers = allInput.Split(',');

      for (int i = 1; i < 10; i++)
      {
        Console.Write("\n" + i + "   ");
        for (int c = 0; c < numbers.Length - 1; c++)
        {
          if (Convert.ToInt32(numbers[c]) == i)
            Console.Write("*");
        }
      }

      Console.WriteLine("\n");

    }
  }
}

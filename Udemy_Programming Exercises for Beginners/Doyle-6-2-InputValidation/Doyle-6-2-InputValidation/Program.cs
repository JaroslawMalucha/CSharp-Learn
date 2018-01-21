/*
Create an application that contains a loop to be used for input validation.
Valid entries are positive integers less than 100. Test your program with values
both less than and greater than the acceptable range as well as non-numeric
data. When the user is finished inputting data, display the number of valid and
invalid entries entered. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doyle_6_2_InputValidation
{
  class Program
  {
    static void Main(string[] args)
    {
      int counterGood = 0;
      int counterBad = 0;
      string input = "";

      do
      {
        Console.WriteLine("Please enter a number 0 - 99, or type Q to quit");
        input = Console.ReadLine();
        if (!input.ToUpper().Equals("Q"))
        {
          int number = 0;
          if (int.TryParse(input, out number))
          {
            if (number >= 0 && number <= 99)
              counterGood++;
            else
              counterBad++;
          }
          else
            counterBad++;
        }
      }
      while (!input.ToUpper().Equals("Q"));

      Console.WriteLine("Valid numbers entered: " + counterGood);
      Console.WriteLine("Invalid numbers entered: " + counterBad);
    }
  }
}

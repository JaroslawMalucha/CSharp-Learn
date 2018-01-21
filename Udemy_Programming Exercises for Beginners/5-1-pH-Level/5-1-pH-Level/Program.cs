/*
Write an application that will enable you to display an aquarium’s pH level. The
pH is a measure of the aquarium water’s alkalinity and is typically given on a 0-14
scale. For most freshwater fish tanks, 7 is neutral. Tanks with a pH lower than 7
are considered acidic. Tanks with a pH higher than 7 are alkaline. Allow the user
to input the pH level number. Display a message indicating the health (i.e.,
acidic, neutral, or alkaline) of the aquarium. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_pH_Level
{
  class Program
  {
    static void Main(string[] args)
    {
      int pH;
      Console.WriteLine("Please enter the pH level: ");
      if (int.TryParse(Console.ReadLine(), out pH) == false || pH < 0 || pH > 14)
        Console.WriteLine("Invalid Input");
      else if (pH < 7)
        Console.WriteLine("pH is Acidic");
      else if (pH > 7)
        Console.WriteLine("pH is Alkaline");
      else
        Console.WriteLine("pH is neutral");
    }
  }
}

/*
Create a Month class that has a single data member of month number. Include
a member method that returns the name of the month and another method that
returns the number of days in the month. The ToString( ) method should
return the name and number of days. Write a second class to test your Month
class. The second class should allow the user to input a month number. Display
the name of the month associated with the number entered and the number of
days in that month. For this exercise, use 28 for February. If the user inputs an
invalid entry, display an appropriate message. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doyle_5_2_MathClass
{
  class TestMonth
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Please enter the month number: ");
      int monthNumber = Convert.ToInt32(Console.ReadLine());

      Month month = new Month(monthNumber);

      Console.WriteLine(month);
    }
  }
}

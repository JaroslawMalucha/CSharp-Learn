/*
Write a program that generates 1000 random numbers between 0 and 100000.
Display the number of odd values generated as well as the smallest and the largest
of values. Output should be displayed in a Windows message box.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_1_RandomNumbers
{
  class Program
  {
    static void Main(string[] args)
    {
      int max = 0;
      int min = 100000;
      int randomNumber;
      int counter = 0;

      Random rand = new Random();

      for (int i = 0; i < 1000; i++)
      {
        randomNumber = rand.Next(0, 100001);
        if (randomNumber % 2 != 0)
        {
          counter++;
          max = (randomNumber > max) ? randomNumber : max;
          min = (randomNumber < min) ? randomNumber : min;
        }
      }

      MessageBox.Show("Max Number: " + max + "\n" +
                      "Min Number: " + min + "\n" +
                      "Total Numbers Generated: " + counter, "Final Results", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
  }
}

/*
Write a program that reads data into an array of type int. Valid values are from 0
to 10. Your program should display how many valid values were inputted as well
as the number of invalid entries. Output a list of distinct valid entries and a count
of how many times that entry occurred.
Use the following test data:
1 7 2 4 2 3 8 4 6 4 4 7
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_Arrays
{
  class Program
  {
    static void Main(string[] args)
    {
      TestArray arr = new TestArray();
      Console.WriteLine("Number of elements: {0}", arr.NumberOfElements.ToString());
      Console.WriteLine("Valid entries: {0}", arr.ValidEntries());
      Console.WriteLine("Invalid entries: {0}", arr.NumberOfElements - arr.ValidEntries());

      int[] entriesCount = arr.CountEntries();
      for (int i = 0; i < entriesCount.Length; i++)
      {
        if (entriesCount[i] > 0)
          Console.WriteLine("Number of occurances for value of {0} is {1} ", i, entriesCount[i]);
      }
    }
  }
}

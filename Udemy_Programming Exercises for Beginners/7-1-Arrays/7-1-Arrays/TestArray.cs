using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_Arrays
{
  class TestArray
  {
    private int[] numbers = { 1, 7, 2, -5, 4, 2, 3, 8, 11,4, 6, 4, 4, 10, 10, 4,7 };

    public TestArray()
    {
      NumberOfElements = numbers.Length;
    }

    public int NumberOfElements { get; set; }

    public int ValidEntries()
    {
      int counter = 0;
      for (int i = 0; i < NumberOfElements; i++)
      {
        if (numbers[i] >= 0 && numbers[i] <= 10)
          counter++;
      }

      return counter;
    }

    public int [] CountEntries()
    {
      int[] numbers2 = new int[11];

      for (int i = 0; i < NumberOfElements; i++)
      {
        if (numbers[i] >= 0 && numbers[i] <= 10)
          numbers2[numbers[i]]++;
      }
      return numbers2;
    }
  }
}

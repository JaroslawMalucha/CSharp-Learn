/*
N will be input by user. And there will be two arrays with N size, one is for positive numbers and the other one is for negative numbers. 
And all numbers in both arrays will be 0 as default. And N numbers will be guessed by your program (you can use Random()). 
Those guessing numbers will be between -100 and 100. If one number guessed and if this number is positive, 
it will be stored to positive number array and if this number is negative, it will be stored to negative number array. 
If the guessed number is zero then it will guess again.
After N numbers are guessed your program will find position sum of numbers. Position sum of numbers are calculated 
by adding two number in the same position of two arrays.
Output will be to show the positive and negative arrays and position number array. 

EXAMPLE: 
Input:
N=5
Let us say Random numbers example: -2,3, 5, -5,-2

Output
Positive numbers(5 of them): 3, 5, 0, 0, 0
Negative numbers (5 of them): -2, -5, -2, 0, 0
Position sum of numbers: 1,0,-2 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbersCalculations
{
  class Program
  {
    public static int[] positiveNumbers;
    public static int[] negativeNumbers;
    public static int N = 0;

    static void Main(string[] args)
    {
      Console.Write("Please enter how many numbers are to be calculated: ");
      N = Convert.ToInt32(Console.ReadLine());

      positiveNumbers = new int[N];
      negativeNumbers = new int[N];

      //populate arrays with zeroes
      PopulateWithZeroes();
      PopulateWithRandomNumbers();
      OutputPositive();
      OutputNegative();
      OutputSum();      
    }

    private static void OutputSum()
    {
      Console.Write("Position Sum of numbers: ");
      for (int i = 0; i < N; i++)
      {
        if (positiveNumbers[i] != 0 || negativeNumbers[i] != 0)
          Console.Write(positiveNumbers[i] + negativeNumbers[i] + ", ");
      }

      Console.WriteLine("");
    }

    private static void OutputNegative()
    {
      Console.Write("Negative Numbers ({0} of them): ", N);
      foreach (var value in negativeNumbers)
        Console.Write(value + ", ");

      Console.WriteLine("");
    }

    private static void OutputPositive()
    {
      Console.Write("Positive Numbers ({0} of them): ", N);
      foreach (var value in positiveNumbers)
        Console.Write(value + ", ");

      Console.WriteLine("");
    }

    private static void PopulateWithRandomNumbers()
    {
      Random rand = new Random();
      int randomNumber = 0;
      bool positiveNumber = false;

      for (int i = 0; i < N; i++)
      {
        bool randomNotZero = false;
        while(!randomNotZero) //if random number is zero, get another number
        {
          randomNumber = rand.Next(-100, 101);
          if (randomNumber != 0)
            randomNotZero = true;
        }

        positiveNumber = (randomNumber > 0) ? true : false;
        AddNumberToArray(randomNumber, positiveNumber);
      }
    }

    private static void AddNumberToArray(int numberToAdd, bool positiveNumber)
    {
      for (int i = 0; i < N; i++)
      {
        if (positiveNumber)
        {
          if (positiveNumbers[i] == 0)
          {
            positiveNumbers[i] = numberToAdd;
            return;
          }
        }
        else
        {
          if (negativeNumbers[i] == 0)
          {
            negativeNumbers[i] = numberToAdd;
            return;
          }
        }
      }
    }

    private static void PopulateWithZeroes()
    {
      for (int i = 0; i < N; i++)
      {
        positiveNumbers[i] = 0;
        negativeNumbers[i] = 0;
      }
    }
  }
}

/*
Businesses frequently attempt to get telephone numbers that are easy for their clients to
remember. If a business can advertise a simple word for its customers to dial, then, no doubt, the
business will receive a few more calls.
Each seven-letter word corresponds to exactly one seven-digit telephone number. The restaurant
wishing to increase its take-home business could surely do so with the number 825-3688 (i.e.,
“TAKEOUT”).
Each seven-digit phone number corresponds to many separate seven-letter words. Unfortunately,
most of these represent unrecognizable juxtapositions of letters. It’s possible, however, that
the owner of a barber shop would be pleased to know that the shop’s telephone number, 424-7288,
corresponds to “HAIRCUT.” The owner of a liquor store would, no doubt, be delighted to find
that the store’s telephone number, 233-7226, corresponds to “BEERCAN.” A veterinarian with the
phone number 738-2273 would be pleased to know that the number corresponds to the letters
“PETCARE.”
Write a C# program that, given a seven-digit number, writes to a file every possible seven-letter
word corresponding to that number. Avoid phone numbers with the digits 0 and 1. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumber
{
  class Program
  {
    static int[] numbers = new int[7];
    static char[][] allLetters = {
                          new char[] { 'A', 'B', 'C'},
                          new char[] { 'D', 'E', 'F'},
                          new char[] { 'G', 'H', 'I' },
                          new char[] { 'J', 'K', 'L' },
                          new char[] { 'M', 'N', 'O' },
                          new char[] { 'P', 'Q', 'R', 'S'},
                          new char[] { 'T', 'U', 'V' },
                          new char[] { 'W', 'X', 'Y', 'Z' }
                          };
    static char[][] letters = new char[7][]; //this will be array of letters available from the 7-digit number

    static void Main(string[] args)
    {
      GetInput();
      GetLettersVariations(); 
    }

    public static void GetInput()
    {
      //get the number from the user. This will correspond with indexes in letters array
      Console.Write("Please enter 7 digit number (do not use number 0 and 1): ");
      string number = Console.ReadLine();

      for (int i = 0; i < 7; i++)
      {
        int index = Convert.ToInt32(number.Substring(i, 1)) - 2; //our dial starts from number 2 (0 and 1 are not used)
        letters[i] = allLetters[index];
      }

      /*
      for (int i = 0; i < 7; i++)
      {
        Console.WriteLine(letters[i]);
      }
      */
    }

    public static void GetLettersVariations()
    {
      string word = "";

      for (int i1 = 0; i1 < letters[0].Length; i1++)
      {
        for (int i2 = 0; i2 < letters[1].Length; i2++)
        {
          for (int i3 = 0; i3 < letters[2].Length; i3++)
          {
            for (int i4 = 0; i4 < letters[3].Length; i4++)
            {
              for (int i5 = 0; i5 < letters[4].Length; i5++)
              {
                for (int i6 = 0; i6 < letters[5].Length; i6++)
                {
                  for (int i7 = 0; i7 < letters[6].Length; i7++)
                  {
                    word = letters[0][i1].ToString();
                    word += letters[1][i2].ToString();
                    word += letters[2][i3].ToString();
                    word += letters[3][i4].ToString();
                    word += letters[4][i5].ToString();
                    word += letters[5][i6].ToString();
                    word += letters[6][i7].ToString();

                    using (System.IO.StreamWriter file =
                      new System.IO.StreamWriter("WriteLines.txt", true))
                    {
                      file.WriteLine(word);
                    }
                    word = "";
                  }
                }
              }
            }
          }
        }
      }
    }
  }
}

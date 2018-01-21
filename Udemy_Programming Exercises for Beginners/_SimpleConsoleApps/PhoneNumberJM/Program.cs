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

        static char[][] letters; //this will be array of letters available from the 7-digit number
        static int[] lettersCurrentPositions;

        static void Main(string[] args)
        {
            GetInput();
            GetLettersVariations();
        }

        public static void GetInput()
        {
            //get the number from the user. This will correspond with indexes in letters array
            int numberSize = 2;
            Console.Write("Please enter " + numberSize + " digit number (do not use number 0 and 1): ");
            string number = Console.ReadLine();

            letters = new char[numberSize][];
            lettersCurrentPositions = new int[numberSize];

            for (int i = 0; i < numberSize; i++)
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
            return;
            string word = "";
            int allCombinationsCount = GetCombinationsCount();
            int currentCombination = 0;
            int stillFixedPosition = letters.GetLength(0) - 2; //last is always looping
            int currentlyLoopingPosition = letters.GetLength(0) - 1;
            int lastPosition = letters.GetLength(0) - 1;
            int maxedCount = 0;

            while (! (currentCombination == allCombinationsCount))
            {
                for (int n = 0; n < letters.GetLength(0); n++)
                {
                    currentCombination++;

                    if ( (letters[n].Length == (lettersCurrentPositions[n] + 1)) && (lastPosition - n == maxedCount-1) || (letters[n].Length == (lettersCurrentPositions[n] + 1)) && n == lastPosition)
                    {
                        lettersCurrentPositions[n] = 0;
                        maxedCount--;
                    }



                    word += letters[0][lettersCurrentPositions[n]].ToString();
                    Console.WriteLine(word);

                    if (n > stillFixedPosition)
                    {

                        if (lastPosition - n == maxedCount || n == lastPosition)
                        {
                            lettersCurrentPositions[n]++;
                        }

                        if (letters[n].Length == (lettersCurrentPositions[n] + 1))
                        {
                            maxedCount++;
                        }
                    }

                }
                Console.WriteLine(word);
                word = "";
            }

        }


        public static int GetCombinationsCount()
        {
            int combinationsCount = 1;
            for (int i = 0; i < letters.GetLength(0); i++)
            {
                combinationsCount *= letters[i].Length;
            }
            return combinationsCount;
        }




    }
}

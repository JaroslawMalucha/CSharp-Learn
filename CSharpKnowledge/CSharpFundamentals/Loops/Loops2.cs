using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Loops
{
    class Loops2
    {
        public static void testLoops()
        {
            ForLoop();
            WhileLoop();
            ForEachLoop();
            MiscTopcs();
        }

        public static void ForLoop()
        {
            Console.WriteLine("Use FOR LOOP to - Print 5,3,2,1");
            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine("i=" + i);
            }
            Console.WriteLine();

            Console.WriteLine("Use FOR LOOP to - Print 11,9,7,5,3,1");
            for (int i = 11; i >= 1; i -= 2)
            {
                Console.WriteLine("i=" + i);
            }
            Console.WriteLine();

            Console.WriteLine("Use FOR LOOP to - Print the cubes of 3,2,1");
            for (int i = 3; i >= 1; i--)
            {
                Console.WriteLine("cube of i={0} is {1}", i, i * i * i);
            }
            Console.WriteLine();

            Console.WriteLine("Use FOR LOOP to - fill an array with 5,6,7 and print the values");
            int[] values = { 5, 6, 7 };
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine("value at index={0} is {1}", i, values[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Use FOR LOOP to - reverse word \"live\" to get \"evil\" ");
            string word = "live";
            char[] wordRev = new char[word.Length];
            int b = 0;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write(word[i]);
                wordRev[b] = word[i];
                b++;
            }
            Console.WriteLine();
            Console.WriteLine("word [{0}] when reversed is [{1}]", word, new string(wordRev));
            Console.WriteLine();
        }

        public static void WhileLoop()
        {
            {
                Console.WriteLine("Use WHILE LOOP to - Print 1,2,3,4,5");
                int i = 1;
                while (i <= 5)
                {
                    Console.WriteLine("i={0}", i);
                    i++;
                }
                Console.WriteLine();
            }

            {
                Console.WriteLine("Use WHILE LOOP to - Print 5,4,3,2,1");
                int i = 5;
                while (i >= 1)
                {
                    Console.WriteLine("i={0}", i);
                    i--;
                }
                Console.WriteLine();
            }

            {
                Console.WriteLine("Use WHILE LOOP to - Print 12,9,6,3,0");
                int i = 12;
                while (i >= 0)
                {

                    Console.WriteLine("i={0}", i);
                    i -= 3;
                }
                Console.WriteLine();
            }

            {
                Console.WriteLine("Use WHILE LOOP to - Print strings from array of strings");
                string[] words = { "Hello", "Dolly!" };
                int i = 0;
                while (i < words.Length)
                {
                    Console.WriteLine("word [{0}] is [{1}]", i, words[i]);
                    i++;
                }
                Console.WriteLine();
            }

            {
                //Console.WriteLine("Use WHILE LOOP to - collect string input until user wants to quit");
                //List<string> words = new List<string>();
                //string s = "";
                //while (!s.Contains("_end_"))
                //{
                //    Console.WriteLine("input something that contains [_end_] to SKIP");
                //    string input = Console.ReadLine();
                //    s += " " + input;
                //}
                //Console.WriteLine(s);
                //Console.WriteLine();
            }
        }

        public static void ForEachLoop()
        {

            {
                Console.WriteLine("Use FOR EACH LOOP to - loop through chars in a string and check if numeric");
                string s = "asdv@#2SA";
                foreach (char c in s)
                {
                    Console.WriteLine("Is {0} a digit? " + char.IsDigit(c), c);
                }
                Console.WriteLine();
            }

            {
                Console.WriteLine("Use FOR EACH LOOP to - scan array to find number 4");
                double[] dbls = { 1, 2, 3, 4, 5, 6, 7, 7, 365, 8, 38, 9, 5, 5, 4, 44, 4, 4, 4 };
                foreach (double d in dbls)
                {
                    Console.WriteLine("{0}==4?" + (d == 4), d);
                }
                Console.WriteLine();
            }

            {
                Console.WriteLine("Use FOR EACH LOOP to - print a JAGGED ARRAY");
                int[][] vals = new int[][]
                {
                    new int[] {4,5,9},
                    new int[] {8,10},
                    new int[] {1,5,9,10,15}
                };
                foreach (int[] c in vals)
                {
                    foreach (int i in c)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            {
                Console.WriteLine("Use FOR EACH LOOP to - loop and sum values in a DOUBLE ARRAY (MATRIX)");
                int[,] vals = new int[2, 3] { { 5, 6, 9 }, { 9, 3, 1 } };
                int sum = 0;
                foreach (var c in vals)
                {
                    sum += c;
                }
                Console.WriteLine("sum = {0}", sum);
                Console.WriteLine();
            }

        }


        public static void MiscTopcs()
        {
            {
                Console.WriteLine("Use DO WHILE LOOP to - print 1,2,3,4,5");
                int x = 1;
                do
                {
                    Console.WriteLine(x);
                    x++;
                } while (x <= 5);
                Console.WriteLine();
            }

            {
                Console.WriteLine("Use any LOOP to - fill an array of length 10");
                double[] values = new double[10];

                for (int index = 0; index < values.Length; index++)
                    values[index] = index / 5.0;
                foreach (double d in values)
                    Console.WriteLine(d);

                Console.WriteLine();
            }

            {
                Console.WriteLine("LOOPING AND CHANGING INDEX");
                int[] values = { 2, 5, 10 };

                for (int i = 1; i <= values.Length; i++)
                    Console.WriteLine(values[i - 1]);
                Console.WriteLine();
            }

            {
                Console.WriteLine("PRINT ARRAY BACKWARDS");
                string[] values = { "You", "Are", "best!" };
                for (int i = 1; i <= values.Length; i++)
                    Console.Write(values[values.Length - i] + " ");
                Console.WriteLine();
                for (int i = values.Length - 1; i >= 0; i--)
                    Console.Write(values[i] + " ");
                Console.WriteLine();
            }
        }




    }
}

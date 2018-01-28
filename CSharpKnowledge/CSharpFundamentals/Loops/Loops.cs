using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Loops
{
    class Loops
    {
        public static void testLoops()
        {
            // ENUMERABLE TYPES:
            // Array
            // String
            // Other Collections

            // SPECIAL INSTRUCTIONS
            //  break - interupts the loop and exits completely
            //  continue - skips to next iteration

            // for
            { 
                for (var i = 1; i <= 10; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                for (var i = 10; i >= 1; i--)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }

                var name = "John Smith";
                for (var i = 0; i < name.Length; i++)
                {
                    Console.WriteLine(name[i]);
                }
            }

            // foreach is a by value assignment extraction loop
            {
                var name = "John Smith"; 
                foreach ( var character in name)
                {
                    Console.WriteLine(character);
                }

                var nums = new int[] { 1, 2, 3, 4 };
                foreach (var num in nums)
                {
                    Console.WriteLine(num);
                }
            }

            // while
            { 
                var i = 0;
                while (i <= 10)
                {
                    if (i % 2 == 0) Console.WriteLine(i);
                    i++;
                }

                while (true)
                {
                    Console.Write("Type your name:");
                    var input = Console.ReadLine();
                    var str = "AS";
                    if (!String.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("@Echo: " + input);
                        //continue;
                    }
                    break;
                }

            }


            // do while - executes at least once
            {
                var i = 1;
                do
                {
                    Console.WriteLine("i={0}", i);
                } while (i<1);
            }

        }
    }
}

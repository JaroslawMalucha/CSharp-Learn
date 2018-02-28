using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    class YieldKeyword
    {
        static List<int> MyList = new List<int>();

        public static void test()
        {
            // Yield:
            // - creates a state machine inside the method, behind the scenes
            // - breaks typical control flow by going back and forth into the method that has the yield keyword
            // - allows observing state during the iteration from outside of the iterating method
            // - makes creating temp collections not needed
            // https://www.codeproject.com/Articles/575713/What-is-the-use-of-csharp-Yield-keyword
            //https://blogs.msdn.microsoft.com/oldnewthing/20080812-00/?p=21273
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/yield

            FillValues(); // Fills the list with 5 values
            foreach (int i in MyList) // Browses through the list
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            foreach (int i in FilterWithoutYield()) // Browses through the list
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            foreach (int i in FilterWithYield()) // Browses through the list
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            foreach (int i in RunningTotal())
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();


        }
        static void FillValues()
        {
            MyList.Add(1);
            MyList.Add(2);
            MyList.Add(3);
            MyList.Add(4);
            MyList.Add(5);
        }
        static IEnumerable<int> FilterWithoutYield()
        {
            List<int> temp = new List<int>();
            foreach (int i in MyList)
            {
                if (i > 3)
                {
                    temp.Add(i);
                }
            }
            return temp;
        }
        static IEnumerable<int> FilterWithYield()
        {
            foreach (int i in MyList)
            {
                if (i > 3) yield return i;
            }
        }

        static IEnumerable<int> RunningTotal()
        {
            int runningtotal = 0;
            foreach (int i in MyList)
            {
                runningtotal += i;
                yield return (runningtotal);

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Collections.Generic
{
    class ListTest
    {
        public static void test()
        {
            // List<T> collection is the same as an ArrayList except that it is a generic collection
            // - elements of a specific type
            // - grows and shrinks automatically
            // - can store nulls and duplicates
            // - can be accessed via indexer, for, foreach loops
            // - ideal for storing and retrieving large number of elements


            // Creating
            List<string> firstList = new List<string>();
            IList<string> secondList = new List<string>();
            List<string> thirdList = new List<string>();

            // Adding
            firstList.Add("England");
            firstList.Add("Hungary");
            firstList.Add("Chine");
            firstList.Add("Germany");
            firstList.Add("Germany");
            firstList.Add("Germany");

            // Displaying
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }

            // Index
            Console.WriteLine(firstList[2]);
            firstList[2] = "Korea";
            Console.WriteLine(firstList[2]);

            // Capacity
            Console.WriteLine("Count is: " + firstList.Count);

            // Sorting
            firstList.Sort();
            P(firstList);

            // Reversing
            firstList.Reverse();
            P(firstList);

            // Removing
            firstList.Remove("Germany");
            P(firstList);

            // Remove At
            firstList.RemoveAt(3);
            P(firstList);

            // Remove Range
            firstList.RemoveRange(3, 1);
            P(firstList);

            // Remove all - CLEAR
            firstList.Clear();
            P(firstList);

            // Remove all - PREDICATE
            firstList = ReCreate();
            firstList.RemoveAll(x => x == "Germany");
            P(firstList);

            firstList.RemoveAll(EndsWith_y);
            P(firstList);

            // Contains
            Console.WriteLine("Contains Egypt: " + firstList.Contains("Egypt"));
            P(firstList);

            // Get Range
            secondList = firstList.GetRange(0, 2);
            P(secondList);


            // Distinct
            firstList = ReCreate();
            thirdList = firstList.Distinct().ToList();
            P(thirdList);

            // Find Item
            string elem = firstList.Find(EndsWith_y);

            // Find Index
            int index = firstList.FindIndex(EndsWith_y);

            // Find All
            thirdList = firstList.FindAll(EndsWith_y);

            // Find Last Item
            elem = firstList.FindLast(EndsWith_y);

            // ForEeach Method
            firstList.ForEach(Print);
            firstList.ForEach(
                delegate (String name)
                {
                    Console.WriteLine(name);
                }
            );

            // Index Of
            firstList.IndexOf("Germany");

            // ... and many a=many more ;)

        }

        private static List<string> ReCreate()
        {
            List<string> firstList = new List<string>();

            firstList.Add("England");
            firstList.Add("Hungary");
            firstList.Add("Italy");
            firstList.Add("Chine");
            firstList.Add("Germany");
            firstList.Add("Germany");
            firstList.Add("Germany");

            return firstList;
        }


        // Search predicate returns true if a string ends in "y".
        private static bool EndsWith_y(String s)
        {
            return s.ToLower().EndsWith("y");
        }
        // Action
        private static void Print(string s)
        {
            Console.WriteLine(s);
        }

        private static void P(IList<string> list)
        {
            Console.WriteLine("----------");
            int i = 0;
            foreach (var item in list)
            {
                Console.WriteLine($"item {i++}: {item}");
            }
            Console.WriteLine("----------");
        }
    }
}

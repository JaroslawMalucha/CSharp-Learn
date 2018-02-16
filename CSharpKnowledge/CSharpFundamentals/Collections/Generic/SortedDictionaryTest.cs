using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Collections.Generic
{
    class SortedDictionaryTest
    {
        public static void test()
        {
            // SortedList uses less memory, faster when if populated at once with sorted data
            // SortedDictionary has faster insertion and removal operatinos on unsorted data
            // 


            // Creation
            SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();

            // Add
            sortedDictionary.Add(1, "Blue");
            sortedDictionary.Add(2, "Green");
            sortedDictionary.Add(7, "Orange");
            sortedDictionary.Add(3, "Black");
            sortedDictionary.Add(9, "White");

            // Displaying
            foreach (var item in sortedDictionary)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            // Access by Key
            sortedDictionary[7] = "Purple";

            // Remove
            sortedDictionary.Remove(9);

            // Remove All - CLEAR
            sortedDictionary.Clear();
            //...etc.

        }
    }
}

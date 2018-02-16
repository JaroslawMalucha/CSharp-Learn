using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Collections.Generic
{
    class SortedListTest
    {
        public static void test()
        {
            // SortedList is a Generic version of a SortedList
            // - collection of key-value pairs that are sorted in ascending order of key
            // - there is a generic and non-generic variant
            // - generic version stores keys and values of specified data types
            // - key must be unique and not null
            // - value can be null and/or duplicate

            // Creating
            SortedList<string, string> sortedList = new SortedList<string, string>();

            // Add
            sortedList.Add("Jack", "12352135");
            sortedList.Add("John", "3252521");
            sortedList.Add("Mayo", "523152");
            sortedList.Add("Flower", "75238951");
            sortedList.Add("BlackBerry", "12312312");
            sortedList.Add("Euphemia", "1231212321");

            // Displaying
            P(sortedList);
            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }

            // Index
            sortedList["Mayo"] = "5125123512";

            // TryGetValue
            sortedList.TryGetValue("Jack", out string number);
            if (number != null)
                Console.WriteLine(number);

            // Remove
            P(sortedList);
            sortedList.Remove("Flower");
            P(sortedList);
            
            // Remove all
            sortedList.Clear();

            // Contains
            Console.WriteLine(sortedList.ContainsKey("Jack"));
            Console.WriteLine(sortedList.ContainsValue("12352135"));
            Console.WriteLine(sortedList.Contains(
                new KeyValuePair<string, string>("Jack", "12352135")
                ));

        }

        private static void P(SortedList<string,string> sortedList)
        {
            Console.WriteLine("---------");
            foreach (var item in sortedList)
            {
                Console.WriteLine(item.Key + " mobile: " + item.Value);
            }
            Console.WriteLine("---------");
        }

    }
}

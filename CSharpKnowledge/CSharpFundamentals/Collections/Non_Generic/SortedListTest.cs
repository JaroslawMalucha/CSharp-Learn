using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Collections.Non_Generic
{
    class SortedListTest
    {
        public static void test()
        {
            // SORTEDLIST (non-generic)
            // - there is generic and non-generic
            // - key-value pairs stored in ascending order of the key (sorted by key)
            // - key must be non-null unique
            // - value can be null or duplicate, of any type


            // Creating
            SortedList sortedList = new SortedList();

            // Adding
            sortedList.Add(1, "Jan");
            sortedList.Add(2, "Jan");
            sortedList.Add(3, "Mar");
            sortedList.Add(4, "Apr");
            sortedList.Add(5, "May");

            // Displaying
            // foreach
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            // for
            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine(sortedList.GetKey(i) + ": " + sortedList.GetByIndex(i));
            }

            // Index
            Console.WriteLine(sortedList[2].ToString());

            // Capacity
            Console.WriteLine(sortedList.Count);

            // Remove - by key
            sortedList.Remove("1");

            // RemoveAt - by position (ordered by key)
            sortedList.RemoveAt(2);

            // Contains - key , value
            Console.WriteLine("Contains key [5]: " + sortedList.Contains(5));
            Console.WriteLine("Contains value [5]: " + sortedList.ContainsValue("May"));


            // Copy to ArrayList - keys , values
            ArrayList array = new ArrayList(sortedList.Keys);
            array = new ArrayList(sortedList.Values);

        }
    }
}

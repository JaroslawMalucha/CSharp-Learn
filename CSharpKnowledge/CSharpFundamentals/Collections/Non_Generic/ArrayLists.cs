using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Collections.Non_Generic
{
    class ArrayLists
    {
        static System.Collections.ArrayList al;

        public static void test()
        {
            // ARRAYLIST:
            // - non-generic
            // - any datatype
            // - automatically resizes
            // - can be null or duplicated

            // Creating
            al = new ArrayList();
            al = new ArrayList(20); //specifies initial capacity
                // another overload uses ICollection, e.g. to output Hashtable.Values

            // Adding
            // accepted type = object
            al.Add("First");
            al.Add("Second");
            al.Add("Fourth");
            //arrayList.Add(3);
            //arrayList.Add(4.5d);

            // Looping
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }

            // Inserting
            al.Insert(2, "Third");

            // Access by Index
            al[2].ToString();

            // Contains - searching
            Console.WriteLine(al.Contains("Tim"));

            // Capacity
            Console.WriteLine(al.Count);

            // Sort
            al.Sort(); // will throw exception if various types are contained, eg. strings and numbers
            P();

            // Reverse
            al.Reverse();
            P();

            al.Reverse(1, al.Count - 1);
            P();

            // Remove - specific object by equality?
            al.Remove("Third");
            P();

            // RemoveAt
            al.RemoveAt(0);
            P();

            // RemoveRange
            al.RemoveRange(0, al.Count);
            P();
            Refill();

            // Remove ALL
            al.Clear();
            P();
            Refill();

            // GetRange - SUBSETTING
            ArrayList names = new ArrayList();
            names = al.GetRange(1, 2);
            P(names);


            // Clone - this will clone the array not the items, 
            //  i.e. items in both arraylists will point to the same items 
            //  ...as only references will be copied
            //  ...since items are boxed then value types will behave as referrence types
            //  ...however since strings are immutable then they will behave almost as value types
            ArrayList al2 = (ArrayList)al.Clone();
            al2[1] = "bla";
            P(al2);
            P(al);

            // Copy - copies contents of ArrayList into a type/size compatible Array
            string[] names2 = new string[al.Count];
            al.CopyTo(names2);

        }

        private static void Refill()
        {
            al.Add("First");
            al.Add("Second");
            al.Add("Fourth");
        }

        private static void P()
        {
            Console.WriteLine("-----------");
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------");
        }
        private static void P(ArrayList arrList)
        {
            Console.WriteLine("-----------");
            foreach (var item in arrList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------");
        }
    }
}

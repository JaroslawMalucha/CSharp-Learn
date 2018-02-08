using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSharpFundamentals.Collections.Non_Generic
{
    class HashTableTest
    {
        public static void test()
        {
            // HASHTABLE
            // - key-value pairs of any datatype
            // - key must be unique and not null
            // - value can be null or duplicate, any type

            // Creating
            Hashtable hash = new Hashtable();

            // Adding
            hash.Add("key", "value");
            hash.Add("MS", "USA");
            hash.Add("IKEA", "SWEDEN");
            hash.Add("Mercedes", "Germany");

            // Displaying
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            // Capacity
            Console.WriteLine($"count is: {hash.Count}");

            // Remove
            hash.Remove("IKEA");
            P(hash);

            // Contains Key
            Console.WriteLine("hash contains key [MS]: " + hash.Contains("MS"));
            Console.WriteLine("hash contains key [MSDS]: " + hash.Contains("MSDS"));

            // Contains Value
            Console.WriteLine("hash contains value [USA]: " + hash.ContainsValue("USA"));
            Console.WriteLine("hash contains value [ASVJAO]: " + hash.ContainsValue("ASVJAO"));

            // Copy to ArrayList
            ArrayList array = new ArrayList(hash.Values);
            P(array);
            array = new ArrayList(hash.Keys);
            P(array);

        }

        public static void P(Hashtable hash)
        {
            Console.WriteLine("-----------");
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            Console.WriteLine("-----------");
        }

        public static void P(ArrayList hash)
        {
            Console.WriteLine("-----------");
            foreach (var item in hash)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Collections.Generic
{
    class DictionaryTest
    {
        public static void test()
        {
            // Dictionary similar to non-generic HashTable

            // Creating
            Dictionary<string, string> dict = new Dictionary<string, string>();

            // Creating with initialization
            Dictionary<int, string> dict2 = new Dictionary<int, string>()
            {
                {1, "James" },
                {2, "James" },
                {3, "Marry" }
            };



            // Add
            dict.Add("Russia", "Moscow");
            dict.Add("Italy", "Rome");
            dict.Add("England", "London");
            dict.Add("Spain", "Madrid");
            dict.Add("Germany", "Berlin");

            // Displaying
            foreach (KeyValuePair<string, string> item in dict)
            {
                Console.WriteLine($"key: {item.Key} , value: {item.Value}");
            }
            for (int i = 0; i < dict.Count; i++)
            {
                Console.WriteLine("key: " + dict.Keys.ElementAt(i));
                Console.Write(" value: " + dict.Values.ElementAt(i));
                Console.Write(" value: " + dict[dict.Keys.ElementAt(i)]);
            }

            // Index
            Console.WriteLine(dict["Russia"]);
            dict["Russia"] = "Moskovia";

            // Capacity
            Console.WriteLine(dict.Count);

            // Try get value
            dict.TryGetValue("Egypt", out string res);
            if (res != null)
                Console.WriteLine("for key [Egypt] value is: " + res);

            // Remove
            dict.Remove("Spain");

            // Remove all - CLEAR
            dict.Clear();

            // Contains
            KeyValuePair<string, string> keyValuePair = new KeyValuePair<string, string>("Italy", "Rome");
            Console.WriteLine(dict.Contains(keyValuePair));
            Console.WriteLine(dict.Contains(new KeyValuePair<string, string>("Italy", "Rome")));

            // Contains Key
            Console.WriteLine(dict.ContainsKey("Italy"));

            // Contains Value
            Console.WriteLine(dict.ContainsValue("Rome"));



        }
    }
}

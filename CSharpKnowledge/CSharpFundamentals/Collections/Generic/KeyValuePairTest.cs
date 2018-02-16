using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Collections.Generic
{
    class KeyValuePairTest
    {
        public static void test()
        {
            // KeyValuePair is a struct thta allows storing a key-value pair
            // allows, e.g. a List to store two pieces of information

            var capitals = new List<KeyValuePair<string, string>>();

            capitals.Add(new KeyValuePair<string, string>("Russia", "Moscow"));
            capitals.Add(new KeyValuePair<string, string>("China", "Bejing"));
            capitals.Add(new KeyValuePair<string, string>("Japan", "Tokyo"));
            capitals.Add(new KeyValuePair<string, string>("Japan", "Tokyo"));

            capitals.RemoveAt(1);

            foreach (var item in capitals)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(GetFirstAndLastName());

        }


        public static KeyValuePair<string,string> GetFirstAndLastName()
        {
            string firstName = "Ahmad";
            string lastName = "Brabra";
            return new KeyValuePair<string, string>(firstName, lastName);
        }

    }
}

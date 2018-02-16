using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Collections.Non_Generic
{
    class NameValueCollectionTest
    {
        public static void test()
        {
            // NameValueCollection:
            // - string,string always
            // - keys can be duplicated

            // Creating
            NameValueCollection cities = new NameValueCollection();

            // Adding
            cities.Add("Germany", "Berlin");
            cities.Add("Germany", "Stutgard");
            cities.Add("Germany", "Frankfurt");
            cities.Add("Poland", "Borne");
            cities.Add("Poland", "Warsaw");

            // Displaying
            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }
            foreach (string item in cities)
            {
                Console.WriteLine(cities[item]);
            }


            // Set - replaces all
            cities.Set("Italy", "Venice");

            // Contains
            Console.WriteLine(cities.HasKeys());

            // Remove - all removed
            cities.Remove("Germany");

            // Remove All - CLEAR
            cities.Clear();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.ExtensionMethods
{
    class ExtensionMethods
    {
        public static void testExtensionMethods()
        {
            string post = "I am driving to Niagra falls to see my frien.";
            Console.WriteLine(post);
            post = post.Shorten(5); // notice the icon in IntelliSense is different for ExtensionMethods
            Console.WriteLine(post);

            IEnumerable<int> nums = new List<int> { 1, 2, 3, 6, 6, 3 };
            var max = nums.Max(); //example of Extension Method for an IEnumerable interface compliant Types

            Console.WriteLine(max);

            int i = 0;
            Console.WriteLine(i.IsGreaterThen(4));


            Console.WriteLine(new DateTime(2012,2,2).MyCustomFormat());
        }

    }
}

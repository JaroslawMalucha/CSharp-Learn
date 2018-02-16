using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    class Arguments
    {
        public static void test()
        {
            // naming , optional, generic
            // params is optional by default
            testito(info: "genericInfo", name: "Boss", a: 12);
            testito(info: "genericInfo", name: "Boss", a: 12, names: new string[]{"bejbe", "blues"}); //safest way
            testito(12, "genericInfo", "Boss", "Dino", "bejbe", "blues");
        }

        private static void testito<T>(int a, T info, string name = "John", string surname = "Doe", params T[] names)
        {
            Console.WriteLine(a + " " + info + " " + name + " " + surname + " ");
        }
    }
}

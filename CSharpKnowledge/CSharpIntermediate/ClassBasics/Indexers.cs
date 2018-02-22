using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.ClassBasics
{
    class Indexers
    {
        public static void test()
        {
            // kinda like an array
            Animals animals = new Animals();
            animals[0] = "Dog";
            animals[1] = "Tiger";
            animals[2] = "Horse";
            Console.WriteLine(animals[2]);


            // kinda like key-value pairs
            HttpCookie.testHttpCookie();

        }

        private class Animals
        {
            private string[] name = new string[100];

            public string this[int index]
            {
                get { return name[index]; }
                set { name[index] = value; }
            }

        }
    }
}

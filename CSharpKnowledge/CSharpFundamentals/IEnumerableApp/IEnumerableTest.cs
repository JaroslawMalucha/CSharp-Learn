using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.IEnumerableApp
{
    class IEnumerableTest
    {
        public static void test()
        {
            // create an IEnumerable collection
            IEnumerable<int> result = from value in Enumerable.Range(0, 11) // Enumerable.Range(1, 10) creates values
                                      select value;
            // use for each
            foreach (var value in result)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();

            // use methods to aggregate
            double avg = result.Average();
            Console.WriteLine(avg);

            // cast to List type, array type
            List<int> list = result.ToList(); //creates new List; a copy
            int[] array = result.ToArray(); //creates new Array; a copy
            IEnumerable<int> ienum = list.AsEnumerable();

            list.Add(11); list.Add(12); list.Add(13); list.Add(14); list.Add(15);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            foreach (var item in ienum)
            {
                Console.WriteLine(item);
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }


            // IEnumerator
            IEnumerator<int> enumerator = list.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }




            ////////////
            // IMPLEMENTING IEnumerable and IEnumerator
            ///////////
            cars.test();


        }
    }
}

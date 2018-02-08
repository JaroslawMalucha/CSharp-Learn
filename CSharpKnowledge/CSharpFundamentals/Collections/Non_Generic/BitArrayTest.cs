using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Collections.Non_Generic
{
    class BitArrayTest
    {
        public static void test()
        {
            // BITARRAY
            // - compact array of bit values represented as booleans

            // Creating
            bool[] boolArray = new bool[4];
            boolArray[0] = false;
            boolArray[1] = false;
            boolArray[2] = false;
            boolArray[3] = true;

            BitArray firstArray = new BitArray(4);
            BitArray secondArray = new BitArray(boolArray);

            // Setting value
            firstArray.Set(0, true);
            firstArray.Set(1, false);
            firstArray.Set(2, true);
            firstArray.Set(3, true);

            // Displaying
            foreach (var item in firstArray)
            {
                Console.WriteLine(item);
            }


            // AND - OR - NOT
            BitArray result = (BitArray) firstArray.Clone();
            result.And(secondArray); //modifies the collection
            P(firstArray);
            P(secondArray);
            P(result);

            result = (BitArray)firstArray.Clone();
            result.Or(secondArray); //modifies the collection
            P(firstArray);
            P(secondArray);
            P(result);

            result = (BitArray)firstArray.Clone();
            result.Not(); //modifies the collection
            P(firstArray);
            P(result);


        }


        private static void P(BitArray bitArray)
        {
            Console.WriteLine("-------");
            foreach (var item in bitArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------");
        }
    }
}

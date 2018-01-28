using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    class Arrays
    {
        public static void ArraysBasics()
        {
            // C#.NET is optimized for Jagged arrays
            // Arrays are fixed size

            // VECTORS
            //int[] nums = new int[]; // incorect <= must have size when creating
            int[] numbers = new int[] { 1, 2, 3 };
            var numbers2 = new int[] { 1, 2, 3 };
            var numbers3 = new[] { 1, 2, 3 };
            var strings = new[] { "1", "2", "3" };
            string[] strings2 = { "1", "2", "3" };

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] { "John", "Jack", "Mary" };


            //RECTANGULAR ARRAYs - MATRIX
            //2d
            var matrix = new int[3, 5];
            var matrix1 = new int[3, 5] 
            {
                {1,2,3,4,5 },
                {6,7,8,9,10},
                {11,12,13,14,15}
            };
            var element = matrix1[0, 0];
            //3d
            var colors = new int[3, 5, 4];


            //JAGGED ARRAYs - ARRAYS OF ARRAYS
            var jaggedArray = new int[3][];
            jaggedArray[0] = new int[4];
            jaggedArray[0] = new int[5];
            jaggedArray[0] = new int[3];


            ////ARRAY FUNCTIONS:
            var arr = new[] { 1, 6, 9, 4, 4, 5 };
            
            //Length
            Console.WriteLine("Length: " + arr.Length);
            
            //IndexOf()
            Console.WriteLine("Index of 4: " + Array.IndexOf(arr, 4));

            //Clear()
            Array.Clear(arr,0,2);

            Console.WriteLine("Effect of Clear()");
            foreach (var n in arr)
                Console.WriteLine(n);

            //Copy()
            int[] another = new int[3];
            Array.Copy(arr, another, 3);

            Console.WriteLine("Effect of Copy()");
            foreach (var n in another)
                Console.WriteLine(n);

            // Sort()
            Array.Sort(arr);

            Console.WriteLine("Effect of Sort()");
            foreach (var n in arr)
                Console.WriteLine(n);

            // Reverse()
            Array.Reverse(arr);

            Console.WriteLine("Effect of Reverse()");
            foreach (var n in arr)
                Console.WriteLine(n);

        }

    }
}

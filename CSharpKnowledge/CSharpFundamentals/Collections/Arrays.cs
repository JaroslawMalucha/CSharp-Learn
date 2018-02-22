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
            // all elements of same type
            //2d
            int[,] matrix0 = new int[3, 5];
            var matrix = new int[3, 5];
            var matrix1 = new int[3, 5]
            {
                {1,2,3,4,5 },
                {6,7,8,9,10},
                {11,12,13,14,15}
            };
            var matrix2 = new int[,] { { 1, 2 }, { 10, 20 }, { 100, 200 } };
            var element = matrix1[0, 0];
            //3d
            var colors = new int[3, 5, 4];
            //foreach
            foreach (var item in matrix1)
            {
                Console.WriteLine(item);
            }
            //for
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    Console.WriteLine(matrix1[i, j]);
                }
            }
            //exercise
            MultidimensionalArraysExercise();

            //JAGGED ARRAYs - ARRAYS OF ARRAYS
            {
                int[][] jaggedArray = new int[3][];
                jaggedArray[0] = new int[4];
                jaggedArray[1] = new int[5];
                jaggedArray[2] = new int[3];
            }

            {
                var jaggedArray = new int[3][];
                jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
                jaggedArray[1] = new int[5] { 1, 2, 3, 4, 5 };
                jaggedArray[2] = new int[3] { 1, 2, 3 };
            }

            {
                int[][] jaggedArray = {
                    new int[] { 1, 2, 3, 4 },
                    new int[] { 1, 2, 3, 4, 5 },
                    new int[] { 1, 2, 3 }
                };
                foreach (var item in jaggedArray)
                {
                    Console.WriteLine(item); //print just the ToString() on the containing arrays, i.e. prints type name
                }
                for (int i = 0; i < jaggedArray.Length; i++)
                {
                    for (int j = 0; j < jaggedArray[i].Length; j++)
                    {
                        Console.WriteLine(jaggedArray[i][j]);
                    }
                }
            }

            //JAGGED ARRAYs - ARRAYS OF MATRIXES
            { int[][,] jaggedMultiArray = new int[3][,];
                jaggedMultiArray[0] = new int[2, 2] { { 1, 2 }, { 3, 4 } };
                jaggedMultiArray[1] = new int[3, 2] { { 10, 10 }, { 20, 20 }, { 30, 30 } };
                jaggedMultiArray[2] = new int[2, 2] { { 3, 5 }, { 1, 2 }};
            }
            
            ////ARRAY FUNCTIONS:
            var arr = new[] { 1, 6, 9, 4, 4, 5 };

            //Length
            Console.WriteLine("Length: " + arr.Length);

            //IndexOf()
            Console.WriteLine("Index of 4: " + Array.IndexOf(arr, 4));

            //Clear()
            Array.Clear(arr, 0, 2);

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

        static void MultidimensionalArraysExercise()
        {
            string[,] array = new string[4, 4];
            array[0, 0] = "Item00";
            array[0, 1] = "Item01";
            array[0, 2] = "Item02";
            array[1, 0] = "Item10";
            array[1, 1] = "Item11";
            array[1, 2] = "Item12";
            array[2, 0] = "Item20";
            array[2, 1] = "Item21";
            array[2, 2] = "Item22";

            Console.WriteLine("\tColumn 1 \tColumn 2 \tColumn 3");
            Console.WriteLine("\t------- \t------- \t-------");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Row " + (i + 1));
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t");
                    Console.Write(array[i, j]);
                    Console.Write("\t");
                    if (j == 2)
                        Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }
}

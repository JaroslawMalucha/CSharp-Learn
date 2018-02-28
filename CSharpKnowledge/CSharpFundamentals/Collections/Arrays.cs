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
            ArraysExercise.test();

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
            //exercise
            JaggedMultidimensionalExercise();

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

        static void JaggedMultidimensionalExercise()
        {
            // Assignment 24 - create jagged array of multuidimemal arrays with any type and sizes and access its data
            var multiJaggedArray = new object[3][,];

            multiJaggedArray[0] = new object[2, 2] { { "Superman", "Clarck Kent" }, { "Batman ", "Bryce Wayne" } };
            multiJaggedArray[1] = new object[3, 2] { { 10, 10 }, { 20, 20 }, { 30, 30 } };
            multiJaggedArray[2] = new object[2, 2] { { 3.5, 5.75 }, { 1.25, 3.67 } };


            foreach (var item in multiJaggedArray)
            {
                Console.WriteLine(item);
                for (int i = 0; i < item.GetLength(0); i++)
                {
                    for (int j = 0; j < item.GetLength(1); j++)
                    {
                        Console.Write(item[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }


    class ArraysExercise
    {
        // Multidimensional Arrays Assignment
        public static void test()
        {
            int RowsNumber = 25;
            int ColumnsNumber = 7;
            int offset = 0;
            string[,] Array2D = new string[RowsNumber, ColumnsNumber];

            #region FillArrayManually
            //Array2D[0, 0] = "R0C0";
            //Array2D[0, 1] = "R0C1";
            //Array2D[0, 2] = "R0C2";
            //Array2D[1, 0] = "R1C0";
            //Array2D[1, 1] = "R1C1";
            //Array2D[1, 2] = "R1C2";
            //Array2D[2, 0] = "R2C0";
            //Array2D[2, 1] = "R2C1";
            //Array2D[2, 2] = "R2C2";
            //Array2D[3, 0] = "R3C0";
            //Array2D[3, 1] = "R3C1";
            //Array2D[3, 2] = "R3C2";
            //Array2D[5, 3] = "R5C3";
            //Array2D[6, 2] = "R6C2";
            //Array2D[10, 1] = "R10C1";
            //Array2D[10, 2] = "R10C2";
            //Array2D[10, 3] = "R10C3";
            //Array2D[10, 4] = "R10C4";
            //Array2D[10, 5] = "R10C5";
            //Array2D[9, 5] = "R9C5";
            //Array2D[8, 5] = "R8C5";
            //Array2D[11, 5] = "R11C5";
            //Array2D[10, 6] = "R10C6";
            //Array2D[12, 6] = "R12C6";
            //Array2D[14, 5] = "R14C5";
            //Array2D[15, 1] = "R15C1";
            //Array2D[15, 2] = "R15C2";
            #endregion

            #region FillArrayAutomatically
            FillArrayAutomatically(Array2D, RowsNumber, ColumnsNumber, offset);
            #endregion

            ShowInRowsAndColumnsFormat(Array2D, RowsNumber, ColumnsNumber, offset);

        }

        #region Methods Sections
        public static void FillArrayAutomatically(dynamic array2D, int row, int column, int numberOffset)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (array2D.GetType().Name == "String[,]")
                        array2D[i, j] = "R" + (i + numberOffset) + "C" + (j + numberOffset);
                }
            }
        }

        public static void ShowInRowsAndColumnsFormat(dynamic array2D, int row, int column, int numberOffset)
        {
            for (int i = 0; i < column; i++)
            {
                Console.Write("\tColumn " + (i + numberOffset));
            }
            Console.WriteLine();
            for (int i = 0; i < column; i++)
            {
                Console.Write("\t--------");
            }
            Console.WriteLine();

            for (int i = 0; i < row; i++)
            {
                Console.Write("Row " + (i + numberOffset));
                for (int j = 0; j < column; j++)
                {
                    Console.Write("\t");
                    Console.Write(array2D[i, j]);
                    Console.Write("\t");
                    if (j == (column - 1))
                        Console.WriteLine();
                }
            }
        }
        #endregion
    }

}

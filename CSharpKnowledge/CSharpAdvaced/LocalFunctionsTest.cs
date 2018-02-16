using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    class LocalFunctionsTest
    {
        public static void test()
        {
            MathOperations(1, 2, 3, 4);
        }


        public static void MathOperations(params int[] numbers)
        {
            Console.WriteLine("Add = " + AddNumbers());

            int AddNumbers()
            {
                int result = 0;
                foreach (var number in numbers)
                {
                    result = result + number;
                }
                return result;
            }

            Console.WriteLine("Multiply = " + MultiNumbers());

            int MultiNumbers()
            {
                int result = 1;
                foreach (var number in numbers)
                {
                    result = result * number;
                }
                return result;
            }
        }

    }
}

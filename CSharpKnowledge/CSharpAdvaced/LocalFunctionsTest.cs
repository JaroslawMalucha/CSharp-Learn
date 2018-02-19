using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    class LocalFunctionsTest
    {
        // Local Functions are declared inside another function
        // - they share context
        //  - local function cannot declare same variables as its parent function
        //  - local function can use vars of the parent function as its own
        //  - is the stack level shared??


        public static void test()
        {
            MathOperations(1, 2, 3, 4);
            ParentMethod();
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

        static void ParentMethod()

        {
            Console.WriteLine("Hi from to the parent method");
            void ChildMethod()
            {
                Console.WriteLine("Hi from the child method");
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Collections.Non_Generic
{
    class StackTest
    {
        public static void test()
        {
            // STACK
            // - LIFO structure

            // Creating
            Stack stack = new Stack();

            // Adding
            stack.Push("David");
            stack.Push("Emmy");
            stack.Push("Jack");
            stack.Push("Emma");

            // Removing
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop()); // throws exception if stack is empty







        }
    }
}

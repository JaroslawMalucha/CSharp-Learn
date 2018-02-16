using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Collections.Generic
{
    class StackTest
    {
        public static void test()
        {
            // GENERIC STACK
            // 


            // Creation
            Stack<string> ram = new Stack<string>();

            // Add = PUSH
            ram.Push("Visual Studio");
            ram.Push("Visual Studio Code");
            ram.Push("Notepad++");

            // Display
            foreach (var item in ram)
            {
                Console.WriteLine(item);
            }

            // Remove = POP
            ram.Pop();

            // Peel - access without removing
            Console.WriteLine(ram.Peek());

        }
    }
}

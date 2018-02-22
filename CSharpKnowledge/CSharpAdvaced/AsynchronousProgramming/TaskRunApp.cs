using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.AsynchronousProgramming
{
    class TaskRunApp
    {
        public static void test()
        {
            SayHiTask();

            AddNumbersTask(10, 2, 12);

            Console.ReadLine();
        }

        private static Task SayHiTask()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Hi there from the task");
            });
        }

        public static Task AddNumbersTask(params int[] numbers)
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Add numbers task started...");
                int result = 0;
                foreach (var number in numbers)
                {
                    result += number;
                }
                Console.WriteLine("Total = " + result);
            });
        }
    }
}

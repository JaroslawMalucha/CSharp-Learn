using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.AsynchronousProgramming
{
     
    class TasksWithReturnValue
    {
        public static void test()
        {
            Task<int> task = new Task<int>(() =>
            {
                int result = 0;
                for (int i = 1; i <= 4; i++)
                {
                    result += i;
                    Console.WriteLine(i);
                }
                return result;
            });
            task.Start();
            Console.WriteLine(task.Result);
            Console.ReadLine();
        }
    }
}

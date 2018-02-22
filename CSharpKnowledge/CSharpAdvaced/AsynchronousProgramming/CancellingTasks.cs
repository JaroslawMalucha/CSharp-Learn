using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpAdvanced.AsynchronousProgramming
{
    class CancellingTasks
    {
        public static void test( )
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(); // a signal called outside of task
            CancellationToken token = cancellationTokenSource.Token; // a receiver of the signal whithin the task

            Task task = new Task(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Task is cancelled!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine(i + 1);
                    }
                }
                Console.WriteLine("Task is Complete!");
            });

            task.Start();

            //Thread.Sleep(3000);
            //cancellationTokenSource.Cancel();
            cancellationTokenSource.CancelAfter(5000);

            Console.ReadLine();
        }
    }
}

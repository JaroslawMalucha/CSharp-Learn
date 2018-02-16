using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Collections.Generic
{
    class QueueTest
    {
        public static void test()
        {
            // GENERIC QUEUE

            // Creating
            Queue<DateTime> arrivals = new Queue<DateTime>();

            // Add to queue
            arrivals.Enqueue(new DateTime(2017, 01, 01));
            arrivals.Enqueue(new DateTime(2017, 01, 04));
            arrivals.Enqueue(new DateTime(2017, 03, 18));
            arrivals.Enqueue(DateTime.Now);

            // Display
            foreach (var item in arrivals)
            {
                Console.WriteLine(item);
            }

            // Peek
            Console.WriteLine(arrivals.Peek());

            // Remove from queue
            arrivals.Dequeue();
            arrivals.Dequeue();
        }
    }
}

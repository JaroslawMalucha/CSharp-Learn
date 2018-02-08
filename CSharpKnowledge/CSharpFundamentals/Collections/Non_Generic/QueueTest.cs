using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Collections.Non_Generic
{
    class QueueTest
    {
        public static void test()
        {
            // QUEUE
            // - FIFO structure


            // Creating
            Queue queue = new Queue();

            // Adding
            queue.Enqueue("Cavin");
            queue.Enqueue("Tom");
            queue.Enqueue("Emma");

            // Removing
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            //  Console.WriteLine(queue.Dequeue()); // throws exception if queue is empty

        }
    }
}

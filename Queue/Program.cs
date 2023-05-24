using System;

namespace Queue
{
    class Queue
    {
        static void Main(string[] args)
        {
            QueueList<int> queue = new QueueList<int>();

            Console.WriteLine("Enqueue 3");
            queue.Enqueue(3);

            Console.WriteLine("Enqueue 4");
            queue.Enqueue(4);


            Console.WriteLine("Peek last value " + queue.Peek());
            Console.WriteLine("Peek last value " + queue.Peek());
            Console.WriteLine("Dequeue last value "+queue.Dequeue());
            Console.WriteLine("Peek last value " + queue.Peek());

        }
    }

  
}

using System;

namespace Queue
{
    class Queue
    {
        static void Main(string[] args)
        {
            QueueList<int> list = new QueueList<int>();

            Console.WriteLine("Enqueue 3");
            list.Enqueue(3);

            Console.WriteLine("Enqueue 4");
            list.Enqueue(4);


            Console.WriteLine("Peek last value " + list.Peek());
            Console.WriteLine("Peek last value " + list.Peek());
            Console.WriteLine("Dequeue last value "+list.Dequeue());
            Console.WriteLine("Peek last value " + list.Peek());

        }
    }

  
}

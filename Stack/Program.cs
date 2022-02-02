using System;
using System.Collections.Generic;
using System.Collections;
namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        { 
            StackList<int> list = new StackList<int>();

            Console.WriteLine("Push 3");
            list.Push(3);

            Console.WriteLine("Push 4");
            list.Push(4);


            Console.WriteLine("Peek last value " + list.Peek());
            Console.WriteLine("Peek last value " + list.Peek());
            Console.WriteLine("Pop last value "+list.Pop());
            Console.WriteLine("Peek last value " + list.Peek());

        }
    }

  
}

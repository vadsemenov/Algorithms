using System;
using System.Collections.Generic;
using System.Collections;
namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        { 
            StackList<int> stack = new StackList<int>();

            Console.WriteLine("Push 3");
            stack.Push(3);

            Console.WriteLine("Push 4");
            stack.Push(4);


            Console.WriteLine("Peek last value " + stack.Peek());
            Console.WriteLine("Peek last value " + stack.Peek());
            Console.WriteLine("Pop last value "+stack.Pop());
            Console.WriteLine("Peek last value " + stack.Peek());

        }
    }

  
}

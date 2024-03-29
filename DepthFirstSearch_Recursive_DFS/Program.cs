﻿namespace DepthFirstSearch_Recursion_DFS;

public class Program
{
    static void Main(string[] args)
    {
        var draw = new Draw(60, 20);
        draw.Frame();
        draw.AddRandomPixels(100);
        draw.DepthFirstSeachRecursion(31, 10, 6);
        Thread.Sleep(300);
        Console.ReadKey();
    }
}
﻿using System;

namespace HelloWorld_Debug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nCual es tu nombre? ");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}!");
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}

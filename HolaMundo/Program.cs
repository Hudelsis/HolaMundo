using System;

namespace HolaMundo
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cual es tu nombre?");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nHola, {name}, y ,{date:d}, y, {date:t}!");
            Console.Write("Precione una tecla para finalizar");
            Console.ReadKey(true);
        }
    }
}

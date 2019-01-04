using System;
using System.Collections.Generic;
using System.Linq;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo input;

            do
            {
                input = Menu("Tuple Demo");
                switch (input.KeyChar)
                {
                    case '1':
                        Console.Clear();
                        ForEachDeconstruction.Example1();
                        break;
                    case '2':
                        Console.Clear();
                        CustomDeconstruct.Run();
                        break;

                }
            } while (input.Key != ConsoleKey.Escape);
        }

        static public ConsoleKeyInfo Menu(string title)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"------- {title} -------");
            Console.WriteLine();
            Console.WriteLine("1. foreach Deconstruction");
            Console.WriteLine("2. Custom Deconstruction");
            Console.WriteLine();
            Console.Write("Press Escape to exit: ");

            return Console.ReadKey();
        }
    }


}


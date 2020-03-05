using System;
using System.Collections.Generic;

namespace IntelliSearch
{
    class Program
    {
        public static void Line()
        {
            for (int x = 0; x < 50; x++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string that will be used throughout the program");
            var input = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("The string will be subtracted on each index");
            Line();
            Sub subtract = new Sub();
            subtract.Process(input, ProcessorConfig.Instance);

            Console.WriteLine();
            Console.WriteLine("The string will add a char on each index");
            Line();
            Add addChar = new Add();
            addChar.Process(input, ProcessorConfig.Instance);

            Console.WriteLine();
            Console.WriteLine("The string will replace two indexes that are next to each other");
            Line();
            Switch test = new Switch();
            test.Process(input, ProcessorConfig.Instance);
            Replace test2 = new Replace();
            test2.Process(input, ProcessorConfig.Instance);
        }
    }
}

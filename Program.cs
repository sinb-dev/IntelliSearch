using System;
using System.Collections.Generic;

namespace IntelliSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string that will be subtracted by each index");
            sub e = new sub();
            e.Process(Console.ReadLine(), ProcessorConfig.Instance);

            Add addChar = new Add();
            addChar.Process(Console.ReadLine(), ProcessorConfig.Instance);
            Switch test = new Switch();
            test.Process("test", ProcessorConfig.Instance);

            Replace test2 = new Replace();
            test2.Process("test", ProcessorConfig.Instance);
        }
    }
}

using System;

namespace IntelliSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            AddChar addChar = new AddChar();
            addChar.Process(Console.ReadLine(), ProcessorConfig.Instance);
        }
    }
}

using System;
using System.Collections.Generic;

namespace IntelliSearch
{
    class Program
    {
        public static string Overskrift(string skrift)
        {
            Console.WriteLine();
            Console.WriteLine(skrift);
            for (int x = 0; x < 50; x++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            return skrift;
        }
        static void Main(string[] args)
        {
            bool isClient = true;
            Console.WriteLine("Start the application with either 'server' or 'client' as argument. Client is used by default");
            
            if (args.Length == 0) {
                args = new string[]{"client"};
            } elseif (args[0] != "client" && args[0] != "server") {
                Console.WriteLine("Argument "+args[0]+" is invalid. Use client or server");
            }
            if (args[0] == "server") {
                isClient = false;
            }

            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.D1 || key.Key == ConsoleKey.NumPad1) {
                Client c = new Client();

                Console.WriteLine("Enter a text");
                string read = Console.ReadLine();
                c.Check(read);
            } else if (key.Key == ConsoleKey.D2 || key.Key == ConsoleKey.NumPad2) {
                API api = new API();
                api.Server();
            }
            return;

            Console.WriteLine("Enter a string that will be used throughout the program");
            var input = Console.ReadLine();

            Overskrift("Subtract");
            Subtract subtract = new Subtract();
            subtract.Process(input, ProcessorConfig.Instance);

            Overskrift("AddChar");
            Add addChar = new Add();
            addChar.Process(input, ProcessorConfig.Instance);

            Overskrift("Switch/Replace");
            Switch test = new Switch();
            test.Process(input, ProcessorConfig.Instance);
            Replace test2 = new Replace();
            test2.Process(input, ProcessorConfig.Instance);

            Overskrift("Yes?");
            Add add = new Add();
            List<string> result = new List<string>();
            WordProcessing wordProcessing = new WordProcessing();
            wordProcessing.AddProcesser(add);
            wordProcessing.ProcessedResults(input, ref result);

            
        }
    }
}

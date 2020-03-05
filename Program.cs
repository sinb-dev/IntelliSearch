using System;

namespace IntelliSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string that will be subtracted by each index");
            sub e = new sub();

            e.Sub(Console.ReadLine());

        }
    }
}

using System;
using System.Collections.Generic;

namespace IntelliSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Add add = new Add();

            List<string> result = new List<string>();

            WordProcessing wordProcessing = new WordProcessing();
            wordProcessing.AddProcesser(add);
            wordProcessing.ProcessedResults("test", ref result);
        }
    }
}

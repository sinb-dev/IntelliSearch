using System;
using System.Collections.Generic;

namespace IntelliSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Switch test = new Switch();
            test.Process("test", ProcessorConfig.Instance);

            Replace test2 = new Replace();
            test2.Process("test", ProcessorConfig.Instance);
        }
    }
}

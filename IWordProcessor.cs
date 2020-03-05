using System;
using System.Collections.Generic;
namespace IntelliSearch 
{
    interface IWordProcessor
    {
        List<string> Process(string word);
    }
}
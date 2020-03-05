using System;
using System.Collections.Generic;
namespace IntelliSearch 
{
    interface IIntelliSearchClient
    {
        //Checks a word
        string Check(string word);
    }
}
using System;
using System.Collections.Generic;

namespace IntelliSearch
{
    class Subtract : IWordProcessor
    {
        public List<string> Process(string word, ProcessorConfig config)
        {
            List<string> newList = new List<string>();
            for (int x = 0; x < word.Length; x++)
            {
                var wordRemove = word.Remove(x, 1);
                newList.Add(wordRemove);
            }
            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }
            return newList;
        }
    }
}

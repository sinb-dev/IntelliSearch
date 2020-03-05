
using System;
using System.Collections.Generic;

namespace IntelliSearch
{
    class Add : IWordProcessor
    {
        public List<string> Process(string word, ProcessorConfig config)
        {
            char[] ChArr = config.CharacterList.ToCharArray();
            List<string> result = new List<string>();

            for (int x = 0; x < ChArr.Length; x++)
            {
                for (int i = 0; i <= word.Length; i++)
                {
                    string addChar = word.Insert(i, ChArr[x].ToString());
                    result.Add(addChar);
                    Console.WriteLine(addChar);
                }

            }
            return result;
        }
    }
}

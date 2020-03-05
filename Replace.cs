using System;
using System.Collections.Generic;
using System.Text;

namespace IntelliSearch
{
    class Replace : IWordProcessor
    {
        public List<string> Process(string word, ProcessorConfig config)
        {
            List<string> result = new List<string>();
            char[] ChArr = config.CharacterList.ToCharArray();

            for (int x = 0; x < ChArr.Length; x++)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    char[] tempArr = word.ToCharArray();
                    tempArr[i] = ChArr[x];
                    result.Add(new string(tempArr));
                    Console.WriteLine(new string(tempArr));
                }
            }

            return result;
        }
    }
}

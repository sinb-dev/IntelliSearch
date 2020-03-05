using System;
using System.Collections.Generic;
using System.Text;

namespace IntelliSearch
{
    class Switch : IWordProcessor
    {
        public List<string> Process(string word, ProcessorConfig config)
        {
            List<string> result = new List<string>();
            char temp;

            for (int i = 0; i < word.Length - 1; i++)
            {
                char[] tempArr = word.ToCharArray();
                temp = tempArr[i];
                tempArr[i] = tempArr[i + 1];
                tempArr[i + 1] = temp;
                result.Add(new string(tempArr));
                Console.WriteLine(new string(tempArr));
            }

            return result;
        }
    }
}

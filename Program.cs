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

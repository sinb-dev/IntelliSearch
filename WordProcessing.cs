using System;
using System.Collections.Generic;
using System.Text;

namespace IntelliSearch
{
    class WordProcessing
    {
        List<IWordProcessor> wordProcessors = new List<IWordProcessor>();
        public void AddProcesser(IWordProcessor processor)
        {
            wordProcessors.Add(processor);
        }

        public void ProcessedResults(string str, ref List<string> result)
        {
            foreach (IWordProcessor proc in wordProcessors)
            {
               result = proc.Process(str, ProcessorConfig.Instance);
            }
        }
    }
}

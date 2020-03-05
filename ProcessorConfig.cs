using System;
using System.Collections.Generic;
namespace IntelliSearch 
{
    public class ProcessorConfig
    {
        public string CharacterList { get; private set;}
        public static ProcessorConfig Instance {get; private set;}
        static ProcessorConfig() {
            Instance = new ProcessorConfig();
            Instance.CharacterList = "abcd";
        }
    }
}
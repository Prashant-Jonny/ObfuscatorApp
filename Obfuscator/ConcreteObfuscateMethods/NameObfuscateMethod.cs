using System;
using ObfuscateMethod.ConcreteObfuscateFiles;
using ObfuscateMethod.ObfuscateMethodCreator;

namespace ObfuscateMethod.ConcreteObfuscateMethods
{
    public class NameObfuscateMethod : IObfuscateMethod
    {
        internal NameObfuscateMethod()
        {
            
        }

        public IObfuscateFile Obfuscate()
        {
            return new NameObfuscateFile();
        }
    }
}

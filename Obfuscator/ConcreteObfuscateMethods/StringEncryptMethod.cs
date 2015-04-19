using System;
using ObfuscateMethod.ConcreteObfuscateFiles;
using ObfuscateMethod.ObfuscateMethodCreator;

namespace ObfuscateMethod.ConcreteObfuscateMethods
{
    public class StringEncryptMethod : IObfuscateMethod
    {
        internal StringEncryptMethod()
        {
            
        }

        public IObfuscateFile Obfuscate()
        {
            return new StringEncryptFile();
        }
    }
}

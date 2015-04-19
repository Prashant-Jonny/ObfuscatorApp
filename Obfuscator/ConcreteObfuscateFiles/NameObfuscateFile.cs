using ObfuscateMethod.ObfuscateMethodCreator;

namespace ObfuscateMethod.ConcreteObfuscateFiles
{
    public class NameObfuscateFile : IObfuscateFile
    {
        public string GetName()
        {
            return "Name obfuscate";
        }
    }
}

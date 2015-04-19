using System.Collections.Generic;
using ObfuscateMethod.ConcreteObfuscateMethods;
using ObfuscateMethod.ObfuscateMethodCreator;

namespace ObfuscateMethod
{
    public class ObfuscateMethods
    {
        public enum Methods
        {
            NameObfuscate,
            StringEncrypt
        };

        private static Dictionary<Methods, IObfuscateMethod> obfuscatorMethods = new Dictionary<Methods, IObfuscateMethod>
        {
            {Methods.NameObfuscate, new NameObfuscateMethod()},
            {Methods.StringEncrypt, new StringEncryptMethod()}
        };

        public static IObfuscateMethod GetObfuscateMethod(Methods method)
        {
            IObfuscateMethod obfuscateMethod;
            obfuscatorMethods.TryGetValue(method, out obfuscateMethod);

            return obfuscateMethod;
        }
    }
}

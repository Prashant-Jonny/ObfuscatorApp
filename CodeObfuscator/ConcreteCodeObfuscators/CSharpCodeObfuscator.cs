using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeObfuscator.CodeObfuscatorStrategy;
using ObfuscateMethod;
using ObfuscateMethod.ObfuscateMethodCreator;

namespace CodeObfuscator.ConcreteCodeObfuscators
{
    class CSharpCodeObfuscator : ICodeObfuscator
    {
        public void Obfuscate()
        {
            var methods = new List<IObfuscateMethod>
            {
                ObfuscateMethods.GetObfuscateMethod(ObfuscateMethods.Methods.NameObfuscate),
                ObfuscateMethods.GetObfuscateMethod(ObfuscateMethods.Methods.StringEncrypt)
            };

            IObfuscateFile obfuscateFile;
            foreach (var method in methods)
            {
                obfuscateFile = method.Obfuscate();
                Console.WriteLine("{0} done.", obfuscateFile.GetName());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeObfuscator.CodeObfuscatorStrategy;
using CodeObfuscator.ConcreteCodeObfuscators;

namespace CodeObfuscator
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new CodeObfuscatorContext(new CSharpCodeObfuscator());

            context.Obfuscate();

            Console.ReadKey();
        }
    }
}

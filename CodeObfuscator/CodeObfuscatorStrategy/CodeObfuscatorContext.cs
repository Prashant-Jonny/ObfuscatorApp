using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeObfuscator.CodeObfuscatorStrategy
{
    public class CodeObfuscatorContext
    {
        private ICodeObfuscator _codeObfuscator;

        public CodeObfuscatorContext(ICodeObfuscator codeObfuscator)
        {
            _codeObfuscator = codeObfuscator;
        }

        public void SetCodeObfuscator(ICodeObfuscator codeObfuscator)
        {
            _codeObfuscator = codeObfuscator;
        }

        public void Obfuscate()
        {
            _codeObfuscator.Obfuscate();
        }
    }
}

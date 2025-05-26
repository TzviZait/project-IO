using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  IO
{
    public static class Decryption
    {
        public static string Atbash(string input)
        {
            // Atbash decryption is the same as encryption
            return Encryption.Atbash(input);
        }
    }
}

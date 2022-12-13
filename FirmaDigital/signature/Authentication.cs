using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FirmaDigital.signature
{
    internal static class Authentication
    {
        public static byte[] Hash512(byte[] bytes)
        {
            var hash = SHA512.Create();
            return hash.ComputeHash(bytes);

        }
    }
}

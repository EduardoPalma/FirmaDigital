using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FirmaDigital.signature
{
    internal class DigitalSignature
    {
        private RSAParameters SharedParameters { get; }
        public RSA Rsa { get; }

        public DigitalSignature()
        {
            Rsa = RSA.Create();
            SharedParameters = Rsa.ExportParameters(false);
        }

        public byte[] GenerateSignature(string path)
        {
            var bytes = File.ReadAllBytes(path);
            return EncryptionAsymmetric.GenerateSignature(bytes, Rsa);
        }

        public bool VerificySignature(string path, byte[] signature)
        {
            var bytes = File.ReadAllBytes(path);
            var hash = Authentication.Hash512(bytes);
            return EncryptionAsymmetric.VerifySignature(signature, hash, SharedParameters);
        }
    }
}

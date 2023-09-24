using System;
using System.Security.Cryptography;

namespace CG.Classes
{
    class hash
    {
        public string Md5(byte[] input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(input);
                // transformando em string
                string senhaCrypto = BitConverter.ToString(hash)
                   // sem -
                   .Replace("-", string.Empty)
                   // minusculo
                   .ToLower();
                return senhaCrypto;
            }
        }
    }
}

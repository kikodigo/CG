using CG.Core.Interfaces;
using CG.Repository.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace CG.Core
{
    public class LoginServices : ILoginServices
    {
        private readonly ILoginRepository _loginRepository;

        public LoginServices(
            ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public async Task<string> connectDB()
        {
            return await _loginRepository.conectDb();
        }

        public async Task<string> Login(string username, string password)
        {
            var encryptedPassword = EncryptPassword(new UTF8Encoding().GetBytes(password));

            

            return "";
        }

        private string EncryptPassword(byte[] input)
        {
            using (var md5 = MD5.Create())
            {
                byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(input);

                string senhaCrypto = BitConverter.ToString(hash)
                   .Replace("-", string.Empty)
                   .ToLower();

                return senhaCrypto;
            }
        }
    }
}

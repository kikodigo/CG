using CG.Repository.Repositories.RepoBase;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace CG.Repository.Repositories
{
    public class LoginRepository
    {

        private readonly QueryBaseRepository _queryBaseRepository;

        public LoginRepository()
        {
            _queryBaseRepository = new QueryBaseRepository();
        }

        public string Login(string username, string password)
        {
            var encryptedPassword = EncryptPassword(new UTF8Encoding().GetBytes(password));

            var query = $"SELECT usuario FROM usuario WHERE usuario = '{username}' AND senha = '{encryptedPassword}'";

            var result = _queryBaseRepository.MySqlByQuery<string>(query);

            return result.FirstOrDefault();

        }

        public ConnectionState StatusDb()
        {
            return _queryBaseRepository.StatusDb();
        }

        #region PrivateMethod

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

        #endregion PrivateMethod
    }
}

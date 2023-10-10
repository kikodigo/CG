using CG.Repository.Config;
using Dapper;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace CG.Repository.Repositories
{
    public class LoginRepository
    {

        private readonly MySqlConnection _mySqlConnection;

        public LoginRepository()
        {
            _mySqlConnection = new MySqlConnection(ConnectionStringConfig.CsSecretGest);
        }

        public async Task<string> conectDb()
        {
            try
            {
                _mySqlConnection.Open();

                Console.WriteLine(_mySqlConnection.State.ToString());

                Console.Error.WriteLine($"Log gerado via MS Logging {_mySqlConnection.State.ToString()}");

                return _mySqlConnection.State.ToString();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Não foi possivel conectar no banco {ex.Message}");

                throw;
            }
            finally
            {
                if (_mySqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _mySqlConnection.Close();
                }
            }
        }

        public async Task<string> Login(string username, string password)
        {
            var encryptedPassword = EncryptPassword(new UTF8Encoding().GetBytes(password));

            var query = $"SELECT usuario FROM usuario WHERE usuario = '{username}' AND senha = '{encryptedPassword}'";

            var result = GetByParams<string>(query);

            return result.FirstOrDefault();

        }


        #region PrivateMethod
        private List<T> GetByParams<T>(string query)
        {
            IEnumerable<T> queryResult = new List<T>();

            try
            {
                _mySqlConnection.Open();


                queryResult = _mySqlConnection.Query<T>(query);

                return (List<T>)queryResult;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                _mySqlConnection.Close();
            }
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

        #endregion PrivateMethod

    }
}

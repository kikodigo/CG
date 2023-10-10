using CG.Repository.Config;
using MySql.Data.MySqlClient;

namespace CG.Repository.Repositories
{
    public class FornecedorRepository 
    {
        private readonly MySqlConnection _mySqlConnection;

        public FornecedorRepository()
        {
            _mySqlConnection = new MySqlConnection(ConnectionStringConfig.CsSecretGest);
        }

        public async Task<string> testDB()
        {
            _mySqlConnection.Open();

            Console.WriteLine(_mySqlConnection.State.ToString());

            Console.Error.WriteLine($"Log gerado via MS Logging {_mySqlConnection.State.ToString()}");

            return _mySqlConnection.State.ToString();
        }
    }
}

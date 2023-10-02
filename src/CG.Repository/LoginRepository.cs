using CG.Repository.Interfaces;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;

namespace CG.Repository
{
    public class LoginRepository : ILoginRepository
    {

        private readonly MySqlConnection _mySqlConnection;

        public LoginRepository(MySqlConnection mySqlConnection)
        {
            _mySqlConnection = mySqlConnection;
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
                if (_mySqlConnection.State != System.Data.ConnectionState.Open)
                {
                    _mySqlConnection.Close();
                }
            }
        }


        public async Task<string> Login(string username, string password)
        {

            _mySqlConnection.Open();

            var estoqueItem = _mySqlConnection.QueryFirstOrDefault<EstoqueItem>("SELECT * FROM estoque WHERE id = @id", new { id = itemId });


        }
    }
}

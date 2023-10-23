using Dapper;
using MySql.Data.MySqlClient;

namespace CG.Repository.Repositories
{
    public class QueryBaseRepository
    {
        private readonly MySqlConnection _mySqlConnection;

        public QueryBaseRepository()
        {
            _mySqlConnection = new MySqlConnection(Environment.GetEnvironmentVariable("csSecretGest"));
        }

        public List<T> MySqlByQuery<T>(string query)
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

        public bool InsertOrUpdateValueOnMySql(MySqlCommand command)
        {
            command.Connection = _mySqlConnection;

            try
            {
                _mySqlConnection.Open();

                var rowsAffetct = command.ExecuteNonQuery();

                return rowsAffetct > 0;
            }
            catch (Exception)
            {
                //GerarLog
                return false;
            }
            finally
            {
                _mySqlConnection.Close();
            }
        }
    }
}

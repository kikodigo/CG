using Dapper;
using MySql.Data.MySqlClient;
using System.Data;

namespace CG.Repository.Repositories
{
    public class QueryBaseRepository
    {
        private readonly MySqlConnection _mySqlConnection;

        public QueryBaseRepository()
        {
            _mySqlConnection = new MySqlConnection(Environment.GetEnvironmentVariable("csSecretGest"));
        }


        private void OpenConnection()
        {
            if (_mySqlConnection.State == ConnectionState.Closed) 
                _mySqlConnection.Open();
        }

        private void CloseConnection() 
        {
            if (_mySqlConnection.State == ConnectionState.Open)
                _mySqlConnection.Close();
        }
        public List<T> MySqlByQuery<T>(string query)
        {
            IEnumerable<T> queryResult = new List<T>();

            try
            {
               OpenConnection();

                queryResult = _mySqlConnection.Query<T>(query);

                return (List<T>)queryResult;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool InsertOrUpdateValueOnMySql(MySqlCommand command)
        {
            command.Connection = _mySqlConnection;

            try
            {
                OpenConnection();

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
                CloseConnection();
            }
        }

        public string StatusDb()
        {
            try
            {
                _mySqlConnection.Open();

                var status = _mySqlConnection.State.ToString();

                return status;
            }
            catch (Exception)
            {
                return "Close";
            }
            finally
            {
                _mySqlConnection.Close();
            }
        }
    }
}

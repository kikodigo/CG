using Dapper;
using MySql.Data.MySqlClient;
using System.Data;

namespace CG.Repository.Repositories.RepoBase
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

        public int InsertUpdateValueOnMySql(MySqlCommand command)
        {
            try
            {
                command.Connection = _mySqlConnection;

                OpenConnection();

                var rowsAffetct = command.ExecuteNonQuery();

                return rowsAffetct;
            }
            catch (Exception)
            {
                //GerarLog
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }

        public int DeleteValueOnMySql(string query)
        {
            try
            {
                OpenConnection();

                var rowsAffetct = _mySqlConnection.Execute(query);

                return rowsAffetct;
            }
            catch (Exception)
            {
                //GerarLog
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }

        public ConnectionState StatusDb()
        {
            try
            {
                OpenConnection();

                var status = _mySqlConnection.State;

                return status;
            }
            catch (Exception)
            {
                return ConnectionState.Closed;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}

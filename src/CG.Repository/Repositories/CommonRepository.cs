using CG.Repository.Constants;
using CG.Repository.Repositories.RepoBase;
using MySqlX.XDevAPI.Relational;

namespace CG.Repository.Repositories
{
    public class CommonRepository
    {
        private readonly QueryBaseRepository _queryBaseRepository;
        private readonly string dbTable;

        public CommonRepository(string table)
        {
            _queryBaseRepository = new QueryBaseRepository();
            dbTable = table;
        }

        public T GetLastValue<T>()
        {
            var query = string.Format(QueryConstants.QUERY_GET_LAST_VALUE, dbTable);

            var result = _queryBaseRepository.MySqlByQuery<T>(query);

            return result.FirstOrDefault();
        }

        public T GetNextValueById<T>(string id)
        {
            var query = string.Format(QueryConstants.QUERY_NEXT_BY_ID, dbTable, id);

            var result = _queryBaseRepository.MySqlByQuery<T>(query);

            return result.FirstOrDefault();
        }

        public T GetPreviousValueById<T>(string id)
        {
            var query = string.Format(QueryConstants.QUERY_PREVIUS_BY_ID, dbTable, id);

            var result = _queryBaseRepository.MySqlByQuery<T>(query);

            return result.FirstOrDefault();
        }

        public List<T> GetAllValue<T>()
        {
            var query = string.Format(QueryConstants.QUERY_GET_ALL, dbTable);

            var result = _queryBaseRepository.MySqlByQuery<T>(query);

            return result;
        }

        public int DeletValueById(string id)
        {
            string query = string.Format(QueryConstants.QUERY_DELETE_BY_ID, dbTable, id);

            var result = _queryBaseRepository.DeleteValueOnMySql(query);

            return result;
        }
    }
}

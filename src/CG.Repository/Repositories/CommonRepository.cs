using CG.Repository.Constants;
using CG.Repository.Repositories.RepoBase;

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
            var query = string.Format(QueryConstants.GET_LAST_VALUE_QUERY, dbTable);

            var result = _queryBaseRepository.MySqlByQuery<T>(query);

            return result.FirstOrDefault();
        }

        public T GetNextValueById<T>(string id)
        {
            var query = string.Format(QueryConstants.GET_NEXT_VALUE_BY_ID_QUERY, dbTable, id);

            var result = _queryBaseRepository.MySqlByQuery<T>(query);

            return result.FirstOrDefault();
        }

        public T GetPreviousValueById<T>(string id)
        {
            var query = string.Format(QueryConstants.GET_PREVIUS_VALUE_BY_ID_QUERY, dbTable, id);

            var result = _queryBaseRepository.MySqlByQuery<T>(query);

            return result.FirstOrDefault();
        }

        public T GetValueById<T>(string id)
        {
            var query = string.Format(QueryConstants.GET_VALUE_BY_ID_QUERY, dbTable, id);

            var result = _queryBaseRepository.MySqlByQuery<T>(query);

            return result.FirstOrDefault();
        }

        public List<T> GetAllValue<T>()
        {
            var query = string.Format(QueryConstants.GET_ALL_VALUES_QUERY, dbTable);

            var result = _queryBaseRepository.MySqlByQuery<T>(query);

            return result;
        }

        public List<T> GetAllValueByReference<T>(string reference, string column)
        {
            var query = string.Format(QueryConstants.GET_VALEUES_LIKE_QUERY, dbTable, column, reference);

            var result = _queryBaseRepository.MySqlByQuery<T>(query);

            return result;
        }

        public int DeletValueById(string id)
        {
            string query = string.Format(QueryConstants.DELETE_VALUE_BY_ID_QUERY, dbTable, id);

            var result = _queryBaseRepository.DeleteValueOnMySql(query);

            return result;
        }
    }
}

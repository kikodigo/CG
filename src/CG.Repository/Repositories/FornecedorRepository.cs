using System.Reflection;
using CG.Domain.Constants;
using CG.Domain.Data;
using CG.Repository.Constants;
using CG.Repository.Repositories.RepoBase;
using CG.Repository.Util;
using MySql.Data.MySqlClient;

namespace CG.Repository.Repositories
{
    public class FornecedorRepository
    {
        private readonly QueryBaseRepository _queryBaseRepository;
        private readonly Mappers _mappers;

        private const string TABLE = TableConstants.FORNEC_TABLE;

        public FornecedorRepository()
        {
            _queryBaseRepository = new QueryBaseRepository();
            _mappers = new Mappers(TABLE);
        }

        public FornecedorData GetLastFornec()
        {
            var query = string.Format(QueryConstants.GET_LAST_VALUE_QUERY, TABLE);

            var result = _queryBaseRepository.MySqlByQuery<FornecedorData>(query);

            return result.FirstOrDefault();
        }

        public FornecedorData GetNextFornecById(string id)
        {
            var query = string.Format(QueryConstants.GET_NEXT_VALUE_BY_ID_QUERY, TABLE, id);

            var result = _queryBaseRepository.MySqlByQuery<FornecedorData>(query);

            return result.FirstOrDefault();
        }

        public FornecedorData GetPreviousFornecById(string id)
        {
            var query = string.Format(QueryConstants.GET_PREVIUS_VALUE_BY_ID_QUERY, TABLE, id);

            var result = _queryBaseRepository.MySqlByQuery<FornecedorData>(query);

            return result.FirstOrDefault();
        }

        public List<FornecedorData> GetAllFornecedor()
        {
            var query = string.Format(QueryConstants.GET_ALL_VALUES_QUERY, TABLE);

            var result = _queryBaseRepository.MySqlByQuery<FornecedorData>(query);

            return result;
        }

        public FornecedorData GetFornecedorByDocNum(string docNum)
        {
            var query = $"SELECT * FROM {TABLE} WHERE DocNum = '{docNum}'";

            var result = _queryBaseRepository.MySqlByQuery<FornecedorData>(query);

            return result.FirstOrDefault();
        }

        public List<FornecedorData> GetAllFornecByReference(string reference, string column)
        {
            return new List<FornecedorData>();
        }

        public int InsertFornec(FornecedorData fornecedor)
        {
            var commandMapped = _mappers.InsertMapper(fornecedor);

            var result = _queryBaseRepository.InsertUpdateValueOnMySql(commandMapped);

            return result;
        }

        public int UpdateFornec(FornecedorData fornecedor)
        {
            var commandMapped = _mappers.UpdateMapper<FornecedorData>(fornecedor);

            var result = _queryBaseRepository.InsertUpdateValueOnMySql(commandMapped);

            return result;
        }

        public int DeletFornecById(string id)
        {
            string query = string.Format(QueryConstants.DELETE_VALUE_BY_ID_QUERY, TABLE, id);

            var result = _queryBaseRepository.DeleteValueOnMySql(query);

            return result;
        }    
    }
}

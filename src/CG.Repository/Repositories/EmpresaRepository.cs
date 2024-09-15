using CG.Domain.Constants;
using CG.Domain.Data;
using CG.Repository.Repositories.RepoBase;
using CG.Repository.Util;
using MySql.Data.MySqlClient;
using System.Reflection;

namespace CG.Repository.Repositories
{
   public class EmpresaRepository
    {
        private readonly QueryBaseRepository _queryBaseRepository;
        private readonly Mappers _mappers;

        private const string Table = TableConstants.EMPRESA_TABLE;

        public EmpresaRepository()
        {
            _queryBaseRepository = new QueryBaseRepository();
            _mappers = new Mappers(Table);
        }

        public int InsertEmpresa(EmpresaData empresa)
        {
            var commandMapped = _mappers.InsertMapper(empresa);

            var result = _queryBaseRepository.InsertUpdateValueOnMySql(commandMapped);

            return result;
        }
        
        public int UpdateEmpresa(EmpresaData empresa)
        {
            var commandMapped = _mappers.UpdateMapper(empresa);

            var result = _queryBaseRepository.InsertUpdateValueOnMySql(commandMapped);

            return result;
        }
    }
}
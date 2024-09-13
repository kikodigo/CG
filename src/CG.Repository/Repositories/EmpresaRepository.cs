using CG.Domain.Constants;
using CG.Domain.Data;
using CG.Repository.Repositories.RepoBase;
using MySql.Data.MySqlClient;

namespace CG.Repository.Repositories
{
   public class EmpresaRepository
    {
        private readonly QueryBaseRepository _queryBaseRepository;

        private const string Table = TableConstants.EMPRESA_TABLE;

        public EmpresaRepository()
        {
            _queryBaseRepository = new QueryBaseRepository();
        }

        public int InsertEmpresa(EmpresaData empresa)
        {
            string insertQuery =
                $"INSERT INTO {Table} (Id, DocNum, Razao, Fantasia, Cep, Endereco, Num, Estado, Cidade, Bairro, Tel1, Tel2, logo) " +
                "VALUES (@Id, @DocNum, @Razao, @Fantasia, @Cep, @Endereco, @Num, @Estado, @Cidade, @Bairro, @Tel1, @Tel2, @logo)";

            var commandMapped = Mapper(empresa, insertQuery);

            var result = _queryBaseRepository.InsertUpdateValueOnMySql(commandMapped);

            return result;
        }
        
        public int UpdateEmpresa(EmpresaData empresa)
        {
            string insertQuery =
                $"UPDATE INTO {Table} (Id, DocNum, Razao, Fantasia, Cep, Endereco, Num, Estado, Cidade, Bairro, Tel1, Tel2, logo) " +
                "VALUES (@Id, @DocNum, @Razao, @Fantasia, @Cep, @Endereco, @Num, @Estado, @Cidade, @Bairro, @Tel1, @Tel2, @logo)";

            var commandMapped = Mapper(empresa, insertQuery);

            var result = _queryBaseRepository.InsertUpdateValueOnMySql(commandMapped);

            return result;
        }


        private MySqlCommand Mapper(EmpresaData empresa, string query)
        {
            var command = new MySqlCommand(query);

            command.Parameters.AddWithValue($"@{nameof(empresa.Id)}", empresa.Id);
            command.Parameters.AddWithValue($"@Razao", empresa.Razao);
            command.Parameters.AddWithValue($"@Fantasia", empresa.Fantasia);
            command.Parameters.AddWithValue($"@DocNum", empresa.DocNum);
            command.Parameters.AddWithValue($"@Cep", empresa.Cep);
            command.Parameters.AddWithValue($"@Endereco", empresa.Endereco);
            command.Parameters.AddWithValue($"@Num", empresa.Num);
            command.Parameters.AddWithValue($"@Estado", empresa.Estado);
            command.Parameters.AddWithValue($"@Cidade", empresa.Cidade);
            command.Parameters.AddWithValue($"@Bairro", empresa.Bairro);
            command.Parameters.AddWithValue($"@Tel1", empresa.Tel1);
            command.Parameters.AddWithValue($"@Tel2", empresa.Tel2);

            return command;
        }
    }
}
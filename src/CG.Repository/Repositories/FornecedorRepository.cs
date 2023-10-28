using CG.Domain.Data;
using MySql.Data.MySqlClient;

namespace CG.Repository.Repositories
{
    public class FornecedorRepository
    {
        private readonly QueryBaseRepository _queryBaseRepository;

        public FornecedorRepository()
        {
            _queryBaseRepository = new QueryBaseRepository();
        }

        public FornecedorData GetLastFornec()
        {
            var query = "SELECT * FROM `fornecedor` ORDER BY ID DESC LIMIT 1";

            var result = _queryBaseRepository.MySqlByQuery<FornecedorData>(query);

            return result.FirstOrDefault();
        }

        public bool InsertFornec(FornecedorData fornecedor)
        {
            string insertQuery = "INSERT INTO fornecedor (Razao, Fantasia, DocNum, Rua, Num, Cep, Uf, Cidade, Bairro, Contato, Tel1, Tel2, Email, Site, TipoCont, Ag, Op, Ct, Pix, Obs, Status) " +
                      "VALUES (@Razao, @Fantasia, @DocNum, @Rua, @Num, @Cep, @Uf, @Cidade, @Bairro, @Contato, @Tel1, @Tel2, @Email, @Site, @TipoCont, @Ag, @Op, @Ct, @Pix, @Obs, @Status)";

            var commandMapped = Mapper(fornecedor, insertQuery);

            var result = _queryBaseRepository.InsertOrUpdateValueOnMySql(commandMapped);

            return result;

        }

        public bool UpdateFornec(FornecedorData fornecedor)
        {
            string updateQuery = "UPDATE fornecedor " +
                                "SET Razao = @Razao, Fantasia = @Fantasia, DocNum = @DocNum, Rua = @Rua, " +
                                "Num = @Num, Cep = @Cep, Uf = @Uf, Cidade = @Cidade, Bairro = @Bairro, " +
                                "Contato = @Contato, Tel1 = @Tel1, Tel2 = @Tel2, Email = @Email, Site = @Site, " +
                                "TipoCont = @TipoCont, Ag = @Ag, Op = @Op, Ct = @Ct, Pix = @Pix, Obs = @Obs, " +
                                "Status = @Status " +
                                "WHERE DocNum = @DocNum";

            var commandMapped = Mapper(fornecedor, updateQuery);

            var result = _queryBaseRepository.InsertOrUpdateValueOnMySql(commandMapped);

            return result;
        }

        public FornecedorData GetFornecedorByDocNum(string docNum)
        {
            var query = $"SELECT * FROM fornecedor WHERE DocNum = '{docNum}'";

            var result = _queryBaseRepository.MySqlByQuery<FornecedorData>(query);

            return result.FirstOrDefault();
        }

        private MySqlCommand Mapper(FornecedorData fornecedor, string query)
        {
            var command = new MySqlCommand(query);

            command.Parameters.AddWithValue("@Razao", fornecedor.Razao);
            command.Parameters.AddWithValue("@Fantasia", fornecedor.Fantasia);
            command.Parameters.AddWithValue("@DocNum", fornecedor.DocNum);
            command.Parameters.AddWithValue("@Rua", fornecedor.Rua);
            command.Parameters.AddWithValue("@Num", fornecedor.Num);
            command.Parameters.AddWithValue("@Cep", fornecedor.Cep);
            command.Parameters.AddWithValue("@Uf", fornecedor.Uf);
            command.Parameters.AddWithValue("@Cidade", fornecedor.Cidade);
            command.Parameters.AddWithValue("@Bairro", fornecedor.Bairro);
            command.Parameters.AddWithValue("@Contato", fornecedor.Contato);
            command.Parameters.AddWithValue("@Tel1", fornecedor.Tel1);
            command.Parameters.AddWithValue("@Tel2", fornecedor.Tel2);
            command.Parameters.AddWithValue("@Email", fornecedor.Email);
            command.Parameters.AddWithValue("@Site", fornecedor.Site);
            command.Parameters.AddWithValue("@TipoCont", fornecedor.TipoCont);
            command.Parameters.AddWithValue("@Ag", fornecedor.Ag);
            command.Parameters.AddWithValue("@Op", fornecedor.Op);
            command.Parameters.AddWithValue("@Ct", fornecedor.Ct);
            command.Parameters.AddWithValue("@Pix", fornecedor.Pix);
            command.Parameters.AddWithValue("@Obs", fornecedor.Obs);
            command.Parameters.AddWithValue("@Status", fornecedor.Status.ToString());

            return command;
        }
    }
}

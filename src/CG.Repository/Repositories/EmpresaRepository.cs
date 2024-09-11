using CG.Domain.Constants;
using CG.Domain.Data;
using CG.Repository.Repositories.RepoBase;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG.Repository.Repositories
{
    class EmpresaRepository
    {
        private readonly QueryBaseRepository _queryBaseRepository;

        private const string TABLE = TableConstants.EMPRESA_TABLE;

        public EmpresaRepository()
        {
            _queryBaseRepository = new QueryBaseRepository();
        }



        private MySqlCommand Mapper(EmpresaData empresa, string query)
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

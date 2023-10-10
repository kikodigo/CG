using CG.Domain.Data;

namespace CG.Repository.Repositories
{
    public class FornecedorRepository
    {
        private readonly QueryBaseRepository _queryBaseRepository;

        public FornecedorRepository()
        {
            _queryBaseRepository = new QueryBaseRepository();
        }

        public async Task<FornecedorData> GetFirstFornec()
        {
            var query = "SELECT * FROM `fornecedor`ORDER BY cod ASC LIMIT 1";

            var result = _queryBaseRepository.MySqlByQuery<FornecedorData>(query);

            return result.FirstOrDefault();
        }
    }
}

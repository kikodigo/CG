using CG.Domain.Data;
using CG.Repository.Repositories;

namespace CG.Core.Services
{
    public class FornecedorServices
    {
        private readonly FornecedorRepository _fornecedorRepository;

        public FornecedorServices()
        {
            _fornecedorRepository = new FornecedorRepository();
        }

        public async Task<FornecedorData> GetFirstFornec()
        {
            return await _fornecedorRepository.GetFirstFornec();
        }
        
        public async Task<bool> InsertFornec(FornecedorData fornecedor)
        {
            var result = _fornecedorRepository.InsertFornec(fornecedor).Result;

            return result;

        }
    }
}

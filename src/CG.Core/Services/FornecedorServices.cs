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

        public async Task<FornecedorData> GetLastFornecAsync()
        {
            return _fornecedorRepository.GetLastFornec();
        }

        public bool InsertFornec(FornecedorData fornecedor)
        {
            //FAZER : Precisa validar se o documento ja existe no banco, se existir retornar erro
            return _fornecedorRepository.InsertFornec(fornecedor);
        }

        public bool UpdateFornec(FornecedorData fornecedor)
        {
            return _fornecedorRepository.UpdateFornec(fornecedor);
        }
    }
}

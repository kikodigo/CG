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

        public async Task<string> TestDB()
        {
            return await _fornecedorRepository.testDB();
        }
    }
}

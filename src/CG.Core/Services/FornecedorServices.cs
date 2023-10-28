using CG.Domain.Data;
using CG.Domain.Response;
using CG.Repository.Repositories;
using MySqlX.XDevAPI.Common;

namespace CG.Core.Services
{
    public class FornecedorServices
    {
        private readonly FornecedorRepository _fornecedorRepository;

        public FornecedorServices()
        {
            _fornecedorRepository = new FornecedorRepository();
        }

        public FornecedorData GetLastFornecAsync()
        {
            return _fornecedorRepository.GetLastFornec();
        }

        public GenericResponse<FornecedorData> InsertFornec(FornecedorData fornecedor)
        {
            var existFornec = _fornecedorRepository.GetFornecedorByDocNum(fornecedor.DocNum);
            bool result = false;

            if (existFornec != null)
            {
                result = _fornecedorRepository.InsertFornec(fornecedor);
            }


            var response = new GenericResponse<FornecedorData>() 
            {
                Data = result,
                HasError = false
            };

            return response;
        }

        public GenericResponse<bool> UpdateFornec(FornecedorData fornecedor)
        {
            var resultRepository = _fornecedorRepository.UpdateFornec(fornecedor);

            var response = new GenericResponse<bool>() 
            { 
                Data = resultRepository,
                HasError = false 
            };

            return response;
        }
    }
}

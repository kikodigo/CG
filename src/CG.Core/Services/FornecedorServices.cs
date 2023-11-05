using CG.Domain.Data;
using CG.Domain.Response;
using CG.Repository.Repositories;
using MySqlX.XDevAPI.Common;
using ZstdSharp.Unsafe;

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

        public GenericResponse<FornecedorData> GetNextFornecById(string id)
        {
            var resultRepository = _fornecedorRepository.GetNextFornecById(id);

            var result = new GenericResponse<FornecedorData>();

            if (resultRepository is not null)
            {
                result.Data = resultRepository;
                result.HasError = false;
            }
            else
            {
                result.HasError = true;
                result.Errors = new List<string>() 
                {
                    "Não existe registro seguinte."
                };
            }

            return result;
        }

        public GenericResponse<FornecedorData> GetPreviousFornecById(string id)
        {
            var resultRepository = _fornecedorRepository.GetPreviousFornecById(id);

            var result = new GenericResponse<FornecedorData>();

            if (resultRepository is not null)
            {
                result.Data = resultRepository;
                result.HasError = false;
            }
            else
            {
                result.HasError = true;
                result.Errors = new List<string>()
                {
                    "Não existe registro anterior."
                };
            }

            return result;
        }

        public GenericResponse<FornecedorData> InsertFornec(FornecedorData fornecedor)
        {
            var existFornec = _fornecedorRepository.GetFornecedorByDocNum(fornecedor.DocNum);

            var response = new GenericResponse<FornecedorData>();

            if (existFornec == null)
            {
                response.HasError = !_fornecedorRepository.InsertFornec(fornecedor);
            }
            else
            {
                response.Errors = new List<string>()
                {
                    $"Ja existe um fornecedor cadastrao com esse documento. \n" +
                        $"RazãoSocial: {existFornec.Razao}"
                };
                response.HasError = true;
                response.Data = existFornec;
            }

            return response;
        }

        public GenericResponse<FornecedorData> UpdateFornec(FornecedorData fornecedor)
        {
            var resultRepository = _fornecedorRepository.UpdateFornec(fornecedor);

            var response = new GenericResponse<FornecedorData>()
            {
                Data = fornecedor,
                HasError = !resultRepository
            };

            return response;
        }
    }
}

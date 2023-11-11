using CG.Domain.Data;
using CG.Domain.Response;
using CG.Repository.Repositories;
using MySqlX.XDevAPI.Common;
using ZstdSharp.Unsafe;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                var rowsAffected = _fornecedorRepository.InsertFornec(fornecedor);

                if (rowsAffected > 0)
                {
                    response.HasError = false;
                }
                else
                {
                    response.HasError = true;
                    response.Errors = new List<string>()
                    {
                       "Correu algum erro na inserção do fornecedor, verifique se ele foi inserido.\n" +
                       "Feche a tela do fornecedor e abra novamente."
                    };
                }

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
            var rowsAffected = _fornecedorRepository.UpdateFornec(fornecedor);

            var response = new GenericResponse<FornecedorData>();

            if (rowsAffected > 0)
            {
                response.Data = fornecedor;
                response.HasError = false;
            }
            else
            {
                response.HasError = true;
                response.Errors = new List<string>()
                {
                    "Correu algum erro no update do fornecedor, verifique se ele foi inserido.\n" +
                    "Feche a tela do fornecedor e abra novamente."
                };
            }

            return response;
        }

        public GenericResponse<bool> DeleteFornec(FornecedorData fornecedor)
        {
            var existFornec = _fornecedorRepository.GetFornecedorByDocNum(fornecedor.DocNum);

            var response = new GenericResponse<bool>();

            if (existFornec is not null)
            {
                var rowsAffected = _fornecedorRepository.DeletFornecById(fornecedor.Id.ToString());

                if (rowsAffected > 0)
                {
                    response.HasError = false;
                }
                else
                {
                    response.HasError = true;
                    response.Errors = new List<string>()
                    {
                        "Correu algum erro no update do fornecedor, verifique se ele foi inserido.\n" +
                        "Feche a tela do fornecedor e abra novamente."
                    };
                }
            }
            else
            {
                response.HasError = true;
                response.Errors = new List<string>()
                {
                    "Não encontramos o fornecedor no banco para ser excluido,\n" +
                    "Por favor, entre em contato com administrador"
                };
            }

            return response;
        }

        public GenericResponseList<FornecedorData> GetAllFornec() 
        {
            var response = new GenericResponseList<FornecedorData>();

            var listFornec = _fornecedorRepository.GetAllFornecedor();

            if (listFornec.Any())
            {
                response.Data = listFornec;
                response.HasError = false;
            }
            else
            {
                response.HasError = true;
                response.Errors = new List<string>()
                {
                    "Nenhuma informação foi localizada"
                };
            }

            return response;   
        }

        public GenericResponseList<FornecedorData> GetAllFornecByReference()
        {
            var response = new GenericResponseList<FornecedorData>();

            var listFornec = _fornecedorRepository.GetAllFornecedor();

            if (listFornec.Any())
            {
                response.Data = listFornec;
                response.HasError = false;
            }
            else
            {
                response.HasError = true;
                response.Errors = new List<string>()
                {
                    "Nenhuma informação foi localizada"
                };
            }

            return response;
        }
    }
}

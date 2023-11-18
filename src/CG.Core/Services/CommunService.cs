using CG.Domain.Data;
using CG.Domain.Response;

namespace CG.Core.Services
{
    public class CommunService
    {
        private string _table;
        public CommunService(string table) 
        {
            _table = table;
        }

        public GenericResponse<T> GetNextFornecById<T>(string id)
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
    }
}

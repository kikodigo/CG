using CG.Domain.Data;
using CG.Domain.Response;
using CG.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG.Core.Services
{
    public class CommunService
    {

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

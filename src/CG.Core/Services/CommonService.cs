using CG.Domain.Response;
using CG.Repository.Repositories;

namespace CG.Core.Services
{
    public class CommonService
    {
        private readonly CommonRepository _commonRepository;

        public CommonService(string table)
        {
            _commonRepository = new CommonRepository(table);
        }

        public T GetLastValueAsync<T>()
        {
            return _commonRepository.GetLastValue<T>();
        }

        public GenericResponse<T> GetNextValueById<T>(string id)
        {
            var resultRepository = _commonRepository.GetNextValueById<T>(id);

            var result = new GenericResponse<T>();

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

        public GenericResponse<T> GetPreviousValueById<T>(string id)
        {
            var resultRepository = _commonRepository.GetPreviousValueById<T>(id);

            var result = new GenericResponse<T>();

            if (resultRepository is not null)
            {
                result.Sucesso();
            }
            else
            {
                result.Falha("Não existe registro anterior");
            }

            return result;
        }

        public GenericResponse<T> GetValueById<T>(string id)
        {
            var resultRepository = _commonRepository.GetValueById<T>(id);

            var result = new GenericResponse<T>();

            if (resultRepository is not null)
            {
                result.Sucesso();
            }
            else
            {
                result.Falha("Registro não encontrato.\n" +
                             "Entre em contato com o Administrador.");
            }

            return result;
        }

        public GenericResponseList<T> GetAllValues<T>()
        {
            var response = new GenericResponseList<T>();

            var listValues = _commonRepository.GetAllValue<T>();

            if (listValues.Any())
            {
                response.Data = listValues;
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

        public GenericResponseList<T> GetAllValuesByReference<T>(string reference, string column)
        {
            var response = new GenericResponseList<T>();

            var listValues = _commonRepository.GetAllValueByReference<T>(reference, column);

            if (listValues.Any())
            {
                response.Data = listValues;
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

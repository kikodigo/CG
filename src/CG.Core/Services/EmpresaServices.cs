using CG.Domain.Constants;
using CG.Domain.Data;
using CG.Domain.Response;
using CG.Repository.Repositories;

namespace CG.Core.Services;

public class EmpresaServices
{
    private readonly EmpresaRepository _empresaRepository;
    private readonly CommonService _commonService;

    public EmpresaServices()
    {
        _empresaRepository = new EmpresaRepository();
        _commonService = new CommonService(TableConstants.EMPRESA_TABLE);
    }

    public GenericResponse<EmpresaData> InsertOrUpdateEmpresa(EmpresaData empresaData)
    {
        var existeEmpresa = _commonService.GetLastValueAsync<EmpresaData>();

        int rowsAffected;
        if (existeEmpresa is null)
        {
            rowsAffected = _empresaRepository.InsertEmpresa(empresaData);
        }
        else
        {
            rowsAffected = _empresaRepository.UpdateEmpresa(empresaData);
        }

        var response = new GenericResponse<EmpresaData>();

        if (rowsAffected > 0)
        {
            response.HasError = false;
        }
        else
        {
            response.HasError = true;
            response.Errors = new List<string>()
            {
                "Ocorreu algum erro na inserção da empresa, verifique se ele foi inserido.\n" +
                "Feche a tela da empresa e abra novamente."
            };
        }
        return response;
    }
}
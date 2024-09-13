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

        if (existeEmpresa is null)
        {
            var existeEmpresa1 = _empresaRepository.InsertEmpresa(empresaData);
        }
        else
        {
            var existeEmpresa1 = _empresaRepository.UpdateEmpresa(empresaData);
        }
        
        
       
        
        
        
        
        
        return new GenericResponse<EmpresaData>();
    }
    
    
}
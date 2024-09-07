using CG.CrossCutting.CEP;
using CG.CrossCutting.SpeedIOCnpj;
using CG.Domain.Data;
using CG.Domain.Data.External;

namespace CG.Core.Services
{
    public class HttpExternalQueries
    {
        public ViaCepData GetEnderecoPorCep(string cep)
        {
            ViaCep _viaCep = new ViaCep();

            return _viaCep.HttpGetViaCep(cep);
        }

        public EmpresaData GetEmpresaPorCNPJ(string cnpj)
        {
            ReceitaWsCnpj _speedIO = new ReceitaWsCnpj();

            return _speedIO.HttpGetEmpresaPorCnpj(cnpj);
        }
    }
}

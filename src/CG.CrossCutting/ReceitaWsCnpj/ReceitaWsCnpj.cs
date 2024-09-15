using CG.Domain.Data;
using CG.Domain.Util;
using Newtonsoft.Json;

namespace CG.CrossCutting.SpeedIOCnpj
{
    public class ReceitaWsCnpj
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public EmpresaData HttpGetEmpresaPorCnpj(string cnpj)
        {
            var endpoint = $"https://receitaws.com.br/v1/cnpj/{cnpj}";
            //https://receitaws.com.br/v1/cnpj/{cnpj} 

            //gratuito a cada 3 consulta / min

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(endpoint)
            };

            var response = _httpClient.SendAsync(request);

            var json = response.Result.Content.ReadAsStringAsync().Result;

            dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(json);

            var empresaData = new EmpresaData
            {
                DocNum = jsonData.cnpj.ToString(),
                Razao = jsonData.nome.ToString(),
                Fantasia = jsonData.fantasia.ToString(),
                Cep = jsonData.cep.ToString(),
                Endereco = jsonData.logradouro.ToString(),
                Num = jsonData.numero.ToString(),
                Estado = jsonData.uf.ToString(),
                Cidade = jsonData.municipio.ToString(),
                Bairro = jsonData.bairro.ToString(),
                Tel1 = jsonData.telefone.ToString()
            };

            return empresaData;
        }

    }
}

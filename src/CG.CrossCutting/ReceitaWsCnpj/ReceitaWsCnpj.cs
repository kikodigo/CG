using CG.Domain.Data;
using CG.Domain.Util;
using System.Text.Json;

namespace CG.CrossCutting.SpeedIOCnpj
{
    public class ReceitaWsCnpj
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public EmpresaData HttpGetEmpresaPorCnpj(string cnpj)
        {
            var endpoint = $"https://receitaws.com.br/v1/cnpj/{cnpj}";

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(endpoint)
            };

            var response = _httpClient.SendAsync(request);

            var json = response.Result.Content.ReadAsStringAsync().Result;

            var result = JsonExtension.JsonToObject<EmpresaData>(json);

            return result;
        }

    }
}

using CG.Domain.Data.External;
using CG.Domain.Util;

namespace CG.CrossCutting.CEP
{
    public class ViaCep
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public ViaCepData HttpGetViaCep(string cep)
        {
            var endpoint = $"https://viacep.com.br/ws/{cep}/json/";

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(endpoint)
            };

            var response = _httpClient.SendAsync(request);

            var json = response.Result.Content.ReadAsStringAsync().Result;

            var endereco = JsonExtension.JsonToObject<ViaCepData>(json);

            return endereco;
        }
    }
}

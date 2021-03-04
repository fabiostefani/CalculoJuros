using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Aplicacao.TaxaJuros
{
    public class AplicTaxaJuros : IAplicTaxaJuros
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public AplicTaxaJuros(IHttpClientFactory httpClientFactory,
                              IConfiguration configuration)
        {
            _httpClient = httpClientFactory.CreateClient();
            _configuration = configuration;
        }
        public async Task<decimal> ObterTaxaPadraoAsync()
        {
            var resp = await _httpClient.GetAsync(ObterUrlApiTaxaJuros());

            resp.EnsureSuccessStatusCode();

            return await JsonSerializer.DeserializeAsync<decimal>(await resp.Content.ReadAsStreamAsync());
        }

        private Uri ObterUrlApiTaxaJuros()
        {
            return new Uri(_configuration["UrlApiTaxaJuros"]);
        }
    }
}

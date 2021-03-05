using Aplicacao.CalculoJuros.Dtos;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace ApiCalculoJuros.TestesIntegracao
{
    public class CalculoJurosControllerTest
    {
        private HttpClient _httpClient;
        private readonly string _endPoint = "/CalculoJuros";

        public CalculoJurosControllerTest()
        {
            var server = new TestServer(new WebHostBuilder().UseStartup<Startup>()
                                                            .UseConfiguration(new ConfigurationBuilder()
                                                            .AddJsonFile("appsettings.json")
                                                            .Build()));

            _httpClient = server.CreateClient();
        }

        [Fact]
        public async Task CalcularAsync_RespostaOk()
        {
            var response = await _httpClient.GetAsync(_endPoint);

            response.EnsureSuccessStatusCode();

            Assert.True(response.IsSuccessStatusCode);
        }

        [Fact]
        public async Task CalcularAsync_DeveRetornar1010()
        {
            var dto = new CalculaJurosDto
            {
                ValorInicial = 1000,
                Meses = 1
            };

            var url = QueryHelpers.AddQueryString(_endPoint, new Dictionary<string, string>
            {
                { nameof(dto.ValorInicial), dto.ValorInicial.ToString() },
                { nameof(dto.Meses), dto.Meses.ToString() }
            });

            var response = await _httpClient.GetAsync(url);

            response.EnsureSuccessStatusCode();

            var valorAtual = await JsonSerializer.DeserializeAsync<decimal>(await response.Content.ReadAsStreamAsync());

            Assert.Equal(1010, valorAtual);
        }
    }
}

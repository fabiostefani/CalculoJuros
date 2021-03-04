using Aplicacao.ShowMeTheCode.View;
using Microsoft.Extensions.Configuration;

namespace Aplicacao.ShowMeTheCode
{
    public class AplicShowMeTheCode : IAplicShowMeTheCode
    {
        private readonly IConfiguration _configuration;

        public AplicShowMeTheCode(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public ShowTheMeCodeReturnView ObterUrls()
        {
            return new ShowTheMeCodeReturnView()
            {
                ApiCalculaJuros = _configuration["UrlCalculoJuros"],
                ApiTaxaJuros = _configuration["UrlTaxaJuros"]
            };
        }
    }
}

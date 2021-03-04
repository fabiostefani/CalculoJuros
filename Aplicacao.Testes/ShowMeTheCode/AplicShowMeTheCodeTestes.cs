using Aplicacao.ShowMeTheCode;
using AutoMoqCore;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace Aplicacao.Testes.ShowMeTheCode
{
    public class AplicShowMeTheCodeTestes
    {
        private readonly AutoMoqer _moker;
        private AplicShowMeTheCode _aplicShowMeTheCode;
        public AplicShowMeTheCodeTestes()
        {
            _moker = new AutoMoqer();
            _aplicShowMeTheCode = _moker.Resolve<AplicShowMeTheCode>();
        }
        [Fact]
        public void ObterUrls_TestaRetornoUrlApiTaxaJuros()
        {
            //Arrange
            var fakeUrlApiTaxaJuros = "http://teste.com.br/GitHubApiTaxaJuros";

            var mockConfiguration = _moker.GetMock<IConfiguration>();
            mockConfiguration.SetupGet(p => p["UrlTaxaJuros"]).Returns(fakeUrlApiTaxaJuros);

            //Act
            var view = _aplicShowMeTheCode.ObterUrls();

            //Test
            Assert.Equal(fakeUrlApiTaxaJuros, view.ApiTaxaJuros);
        }

        [Fact]
        public void ObterUrls_TestaRetornoUrlApiCalculoJuros()
        {
            //Arrange
            var fakeUrlApiCalculoJuros = "http://teste.com.br/GitHubApiCalculoJuros";

            var mockConfiguration = _moker.GetMock<IConfiguration>();
            mockConfiguration.SetupGet(p => p["UrlCalculoJuros"]).Returns(fakeUrlApiCalculoJuros);

            //Act
            var view = _aplicShowMeTheCode.ObterUrls();

            //Test
            Assert.Equal(fakeUrlApiCalculoJuros, view.ApiCalculaJuros);
        }
    }
}

using Aplicacao.CalculoJuros;
using Aplicacao.CalculoJuros.Dtos;
using Aplicacao.TaxaJuros;
using AutoMoqCore;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace Aplicacao.Testes.CalculoJuros
{
    public class AplicCalculoJurosTestes
    {
        private readonly AutoMoqer _moker;
        private AplicCalculoJuros _aplicShowMeTheCode;
        public AplicCalculoJurosTestes()
        {
            _moker = new AutoMoqer();
            _aplicShowMeTheCode = _moker.Resolve<AplicCalculoJuros>();
        }
        [Fact]
        public async Task CalcularAsync_TesteValorCorreto()
        {
            //arrange
            var mockTaxaJurosAplic = _moker.GetMock<IAplicTaxaJuros>();
            mockTaxaJurosAplic.Setup(p => p.ObterTaxaPadraoAsync()).ReturnsAsync(0.01m);

            var dto = new CalculaJurosDto
            {
                ValorInicial = 100_000,
                Meses = 60
            };

            //act
            var valorAtual = await _aplicShowMeTheCode.CalcularAsync(dto);

            //test
            Assert.Equal(181_669.66m, valorAtual);
        }
    }
}

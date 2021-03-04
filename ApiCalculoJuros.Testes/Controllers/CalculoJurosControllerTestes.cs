using ApiCalculoJuros.Controllers;
using Aplicacao.CalculoJuros;
using Aplicacao.CalculoJuros.Dtos;
using AutoMoqCore;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace ApiCalculoJuros.Testes.Controllers
{
    public class CalculoJurosControllerTestes
    {
        private readonly AutoMoqer _moker;
        private Mock<IAplicCalculoJuros> _aplicCalculoJuros;
        public CalculoJurosControllerTestes()
        {
            _moker = new AutoMoqer();
            _aplicCalculoJuros = _moker.GetMock<IAplicCalculoJuros>();
        }
        [Fact]
        public async Task CalcularAsync_VerificarSeEstaChamandoMetodoAplic()
        {
            //arrange
            _aplicCalculoJuros.Setup(p => p.CalcularAsync(It.IsAny<CalculaJurosDto>())).ReturnsAsync(100m);

            //act
            var calculaJurosController = new CalculoJurosController(_aplicCalculoJuros.Object);
            var valorAtual = await calculaJurosController.CalcularAsync(new CalculaJurosDto());

            //test
            _aplicCalculoJuros.Verify(x => x.CalcularAsync(It.IsAny<CalculaJurosDto>()));
        }
    }
}

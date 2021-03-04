using ApiCalculoJuros.Controllers;
using Aplicacao.ShowMeTheCode;
using Aplicacao.ShowMeTheCode.View;
using AutoMoqCore;
using Moq;
using Xunit;

namespace ApiCalculoJuros.Testes.Controllers
{
    public class ShowMeTheCodeControllerTestes
    {
        private readonly AutoMoqer _moker;
        private Mock<IAplicShowMeTheCode> _aplicShowMeTheCode;
        public ShowMeTheCodeControllerTestes()
        {
            _moker = new AutoMoqer();
            _aplicShowMeTheCode = _moker.GetMock<IAplicShowMeTheCode>();
        }
        [Fact]
        public void ObterUrls_VerificaSeEstaChamandoMetodoAplic()
        {
            //arrange
            var fakeUrlApiTaxaJuros = "http://teste.com.br/GitHubApiTaxaJuros";

            _aplicShowMeTheCode.Setup(p => p.ObterUrls()).Returns(new ShowTheMeCodeReturnView
            {
                ApiTaxaJuros = fakeUrlApiTaxaJuros,
            });

            var showMeTheCodeController = new ShowMeTheCodeController(_aplicShowMeTheCode.Object);

            //act            
            var view = showMeTheCodeController.ObterUrls();

            //test
            _aplicShowMeTheCode.Verify(x => x.ObterUrls());
        }


    }
}

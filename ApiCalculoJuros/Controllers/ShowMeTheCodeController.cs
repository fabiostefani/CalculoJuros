using Aplicacao.ShowMeTheCode;
using Aplicacao.ShowMeTheCode.View;
using Microsoft.AspNetCore.Mvc;

namespace ApiCalculoJuros.Controllers
{
    [ApiController]
    [Route("ShowMeTheCode")]
    public class ShowMeTheCodeController : ControllerBase
    {
        private readonly IAplicShowMeTheCode _aplicShowMeTheCode;

        public ShowMeTheCodeController(IAplicShowMeTheCode aplicShowMeTheCode)
        {
            _aplicShowMeTheCode = aplicShowMeTheCode;
        }

        [HttpGet]
        public ShowTheMeCodeReturnView ObterUrls()
        {
            return _aplicShowMeTheCode.ObterUrls();
        }
    }
}

using Aplicacao.CalculoJuros;
using Aplicacao.CalculoJuros.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApiCalculoJuros.Controllers
{
    [ApiController]
    [Route("calculajuros")]
    public class CalculoJurosController : ControllerBase
    {
        private readonly IAplicCalculoJuros _aplicCalculoJuros;

        public CalculoJurosController(IAplicCalculoJuros aplicCalculoJuros)
        {
            _aplicCalculoJuros = aplicCalculoJuros;
        }
        [HttpGet]
        public async Task<decimal> CalcularAsync([FromQuery] CalculaJurosDto dto)
        {
            return await _aplicCalculoJuros.CalcularAsync(dto);
        }
    }
}

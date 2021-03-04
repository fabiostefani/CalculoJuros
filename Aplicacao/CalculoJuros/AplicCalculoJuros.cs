using Aplicacao.CalculoJuros.Calculadora;
using Aplicacao.CalculoJuros.Dtos;
using Aplicacao.TaxaJuros;
using System.Threading.Tasks;

namespace Aplicacao.CalculoJuros
{
    public class AplicCalculoJuros : IAplicCalculoJuros
    {
        private readonly IAplicTaxaJuros _aplicTaxaJuros;

        public AplicCalculoJuros(IAplicTaxaJuros aplicTaxaJuros)
        {
            _aplicTaxaJuros = aplicTaxaJuros;
        }
        public async Task<decimal> CalcularAsync(CalculaJurosDto dto)
        {
            var juros = await _aplicTaxaJuros.ObterTaxaPadraoAsync();
            return CalculadoraJuros.Calcular(dto.ValorInicial, dto.Meses, juros);
        }
    }
}

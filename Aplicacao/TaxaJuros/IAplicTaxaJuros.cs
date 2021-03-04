using System.Threading.Tasks;

namespace Aplicacao.TaxaJuros
{
    public interface IAplicTaxaJuros
    {
        Task<decimal> ObterTaxaPadraoAsync();
    }
}

using Aplicacao.CalculoJuros.Dtos;
using System.Threading.Tasks;

namespace Aplicacao.CalculoJuros
{
    public interface IAplicCalculoJuros
    {
        Task<decimal> CalcularAsync(CalculaJurosDto dto);
    }
}

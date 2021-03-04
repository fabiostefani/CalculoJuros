using Aplicacao.CalculoJuros.Calculadora;
using Xunit;

namespace Aplicacao.Testes.CalculoJuros
{
    public class CalculadoraJurosTestes
    {
        [Theory]
        [InlineData(100_000, 60, 0.01, 181_669.66)]
        [InlineData(200_000, 120, 0.005, 363_879.34)]
        public void Calcular_ValidarCalculo(decimal valorInicial, int meses, decimal juros, decimal valorEsperado)
        {
            var valorCalculado = CalculadoraJuros.Calcular(valorInicial, meses, juros);

            Assert.Equal(valorEsperado, valorCalculado);
        }
    }
}

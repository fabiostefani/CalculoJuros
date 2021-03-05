using System;

namespace Aplicacao.CalculoJuros.Calculadora
{
    public static class CalculadoraJuros
    {
        public static decimal Calcular(decimal valorInicial, int meses, decimal juros)
        {
            var valorJuros = (double)valorInicial * Math.Pow((1 + (double)juros), meses);
            return decimal.Parse(valorJuros.ToString("0.00"));
        }

        private static decimal TruncateDecimal(this decimal valor, int decimais)
        {
            decimal valorIntegral = Math.Truncate(valor);

            decimal fracao = valor - valorIntegral;

            decimal fator = (decimal)Math.Pow(10, decimais);

            decimal fracaoTruncada = Math.Truncate(fracao * fator) / fator;

            decimal resultado = valorIntegral + fracaoTruncada;

            return resultado;
        }
    }
}

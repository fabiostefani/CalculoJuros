﻿using System;

namespace Aplicacao.CalculoJuros.Calculadora
{
    public static class CalculadoraJuros
    {
        public static decimal Calcular(decimal valorInicial, int meses, decimal juros)
        {
            var valorJuros = (double)valorInicial * Math.Pow((1 + (double)juros), meses);
            return decimal.Parse(valorJuros.ToString("0.00"));
        }
    }
}

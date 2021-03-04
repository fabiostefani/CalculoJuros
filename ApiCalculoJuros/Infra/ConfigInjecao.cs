using Aplicacao.CalculoJuros;
using Aplicacao.ShowMeTheCode;
using Aplicacao.TaxaJuros;
using Microsoft.Extensions.DependencyInjection;

namespace ApiCalculoJuros.Infra
{
    public static class ConfigInjecao
    {
        public static void RegistrarInjecao(this IServiceCollection services)
        {
            services.AddScoped<IAplicCalculoJuros, AplicCalculoJuros>();
            services.AddScoped<IAplicTaxaJuros, AplicTaxaJuros>();
            services.AddScoped<IAplicShowMeTheCode, AplicShowMeTheCode>();


        }
    }
}

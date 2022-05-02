using CurriculoGerenciator.Application;
using Microsoft.Extensions.DependencyInjection;

namespace CurriculoGerenciator.IoC
{
    public static class ConfigureBindingsServices
    {
        public static void RegisterBindings(IServiceCollection services)
        {
            services.AddScoped<DadosPessoaService>();
        }
    }
}

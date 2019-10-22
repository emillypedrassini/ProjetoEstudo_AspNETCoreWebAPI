using Microsoft.Extensions.DependencyInjection;

namespace MinhaAPI.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            //Mapear as injeções de dependencias

            //services.AddScoped<IFornecedorRepository, FornecedorRepository>();

            return services;
        }
    }
}

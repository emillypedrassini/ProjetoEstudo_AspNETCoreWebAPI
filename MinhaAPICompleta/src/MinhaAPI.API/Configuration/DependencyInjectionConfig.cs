using Microsoft.Extensions.DependencyInjection;
using MinhaAPI.Business.Interfaces.Repositories;
using MinhaAPI.Data.Repository;

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

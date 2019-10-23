using Microsoft.Extensions.DependencyInjection;
using MinhaAPI.Data.Context;

namespace MinhaAPI.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            //Mapear as injeções de dependencias

            services.AddScoped<MinhaApiDbContext>();

            //services.AddScoped<IFornecedorRepository, FornecedorRepository>();

            return services;
        }
    }
}

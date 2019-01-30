using Marco.CleanArchitecture.Application.Repositories;
using Marco.CleanArchitecture.Infrastructure.InMemoryDataAcess;
using Marco.CleanArchitecture.Infrastructure.InMemoryDataAcess.Repositories;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DataAcessInMemoryServiceCollectionExtensions
    {
        public static IServiceCollection AddDataAcessInMemory(this IServiceCollection services)
        {
            if (services is null)
                throw new ArgumentNullException(nameof(services));

            services.AddSingleton<DataAcessInMemoryContext>();
            services.AddScoped<IProductReadOnlyRepository, ProductRepository>();
            services.AddScoped<IProductWriteOnlyRepository, ProductRepository>();

            return services;
        }
    }
}
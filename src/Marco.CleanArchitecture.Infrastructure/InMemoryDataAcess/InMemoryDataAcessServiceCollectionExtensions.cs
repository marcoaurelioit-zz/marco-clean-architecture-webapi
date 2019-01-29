using Marco.CleanArchitecture.Infrastructure.InMemoryDataAcess;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class InMemoryDataAcessServiceCollectionExtensions
    {
        public static IServiceCollection AddInMemoryDataAcess(this IServiceCollection services)
        {
            if (services is null)
                throw new ArgumentNullException(nameof(services));

            services.AddSingleton<InMemoryContext>();

            return services;
        }
    }
}
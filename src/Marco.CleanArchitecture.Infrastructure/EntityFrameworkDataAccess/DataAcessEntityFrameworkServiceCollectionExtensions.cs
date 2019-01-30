using Marco.CleanArchitecture.Application.Repositories;
using Marco.CleanArchitecture.Infrastructure.EntityFrameworkDataAccess;
using Marco.CleanArchitecture.Infrastructure.EntityFrameworkDataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DataAcessEntityFrameworkServiceCollectionExtensions
    {
        public static IServiceCollection AddDataAcessEntityFramework(this IServiceCollection services, IConfiguration configuration)
        {
            if (services is null)
                throw new ArgumentNullException(nameof(services));

            if (configuration is null)
                throw new ArgumentNullException(nameof(configuration));

            DataAcessEntityFrameworkSettings dataAcessEntityFrameworkSettings = configuration
                .GetSection(nameof(DataAcessEntityFrameworkSettings))
                .TryGet<DataAcessEntityFrameworkSettings>() ??
                     throw new ArgumentNullException(nameof(dataAcessEntityFrameworkSettings));         

            services.AddSingleton(dataAcessEntityFrameworkSettings);

            services.AddScoped<IProductReadOnlyRepository, ProductRepository>();
            services.AddScoped<IProductWriteOnlyRepository, ProductRepository>();

            services.AddDbContext<DataAccessEntityFrameworkContext>(opt => opt.UseSqlServer(dataAcessEntityFrameworkSettings.DefaultConnection));

            return services;
        }
    }
}
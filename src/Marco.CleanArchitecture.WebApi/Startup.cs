using Marco.AspNetCore.WebApi.BootStrapper;
using Marco.CleanArchitecture.Application.UseCases.GetProductDetails;
using Marco.CleanArchitecture.WebApi.UseCases.GetProductDetails;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;

namespace Marco.CleanArchitecture.WebApi
{
    public class Startup : ApiBootStrapper
    {
        protected override ApiInfo ApiInfo => new ApiInfo()
        {
            Name = "Marco API Clean Architecture",
            Description = "API Clean Architecture.",
            DefaultVersion = "1.0"
        };

        public Startup(IConfiguration configuration)
         : base(configuration)
        {
        }

        [ExcludeFromCodeCoverage]
        protected override void AddCustomApiServices(IServiceCollection services)
        {
            services.AddInMemoryDataAcess();

            #region [+] Use Cases
            services.AddScoped<ProductDetailsPresenter>();
            services.AddScoped<IGetProductDetailsUseCase, GetProductDetailsUseCase>();
            #endregion
        }

        [ExcludeFromCodeCoverage]
        protected override void AddCustomMiddlewaresInPipeline(IApplicationBuilder app)
        {

        }    
    }
}
using Marco.AspNetCore.WebApi.BootStrapper;
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
            Name = "Marco Asp Net Core - Clean Architecture",
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
        }

        [ExcludeFromCodeCoverage]
        protected override void AddCustomMiddlewaresInPipeline(IApplicationBuilder app)
        {
        }
    }
}
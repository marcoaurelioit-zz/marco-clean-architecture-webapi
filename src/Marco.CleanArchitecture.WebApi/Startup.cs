using Marco.CleanArchitecture.Application;
using Marco.CleanArchitecture.WebApi.Filters;
using Marco.CleanArchitecture.WebApi.UseCases;
using Marco.CleanArchitecture.WebApi.UseCases.GetProductDetails;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace Marco.CleanArchitecture.WebApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });

            services.AddMvc(options =>
            {
                options.Filters.Add(typeof(DomainExceptionFilter));
                options.Filters.Add(typeof(ModelValidateAttribute));
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Marco.CleanArchitecture.WebApi", Version = "v1" });
            });

            #region [+] Use Cases     
            services.AddScoped<ProductDetailsPresenter>();

            services.Scan(scan => scan
               .FromAssemblyOf<IUseCase>()
               .AddClasses(classes => classes.AssignableTo<IUseCase>())
               .AsImplementedInterfaces()
               .WithScopedLifetime());
            #endregion

            #region [+] Exceptions
            services.Scan(scan => scan
              .FromAssemblyOf<ApplicationException>()
              .AddClasses(classes => classes.AssignableTo<ApplicationException>())
              .AsImplementedInterfaces()
              .WithScopedLifetime());
            #endregion
                       
            services.AddInMemoryDataAcess();
            services.AddMarcoLogger(Configuration);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("CorsPolicy");

            app.UseMvc();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Marco.CleanArchitecture.WebApi V1");
                c.RoutePrefix = string.Empty;
            });
        }
    }
}
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace NorthWind.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddNorthwindDependencies()
                    .AddHostDependencies(Configuration.GetConnectionString("mysql"));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger()
               .UseSwaggerUI(config =>
            {
                config.SwaggerEndpoint("/swagger/v1/swagger.json", "Northwind API V1.0");
                config.RoutePrefix = string.Empty; // https://localhost:5001/index.html
            });

            app.UseHttpsRedirection();
            app.UseNorthwind();
        }
    }
}

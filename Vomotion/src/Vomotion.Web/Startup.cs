using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Vomotion.Domain.Repositories;
using Vomotion.Persistence.Repositories;
using Vomotion.Persistence;
using Vomotion.Services.Abstractions;
using Vomotion.Services;
using Vomotion.Web.Middleware;

namespace Vomotion.Web;

public class Startup
{
    public Startup(IConfiguration configuration) => Configuration = configuration;

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers()
            .AddApplicationPart(typeof(Vomotion.Presentation.AssemblyReference).Assembly);

        services.AddSwaggerGen(c =>
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Web", Version = "v1" }));

        services.AddScoped<IServiceManager, ServiceManager>();

        services.AddScoped<IRepositoryManager, RepositoryManager>();

        services.AddDbContextPool<RepositoryDbContext>(builder =>
        {
            var connectionString = Domain.Settings.EnvironmentVariables.ConnectionString;
            connectionString   ??= Configuration.GetConnectionString("Database");

            builder.UseNpgsql(connectionString);
        });

        services.AddTransient<ExceptionHandlingMiddleware>();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();

            app.UseSwagger();

            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Web v1"));
        }

        app.UseMiddleware<ExceptionHandlingMiddleware>();

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints => endpoints.MapControllers());
    }

}

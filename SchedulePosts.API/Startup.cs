using Microsoft.OpenApi.Models;
using SchedulePosts.API.Configurations;
using Serilog;

namespace SchedulePosts.API;

public class Startup
{
    private readonly IConfiguration _configuration;
    private readonly bool _inMemory;

    public Startup(IConfiguration configuration, bool inMemory)
    {
        _configuration = configuration;
        _inMemory = inMemory;
    }


    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        //TODO: register services
        
        
        services.ConfigureSwagger(_configuration);
    }

    public void Configure(WebApplication app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            Log.Information("Configuring development exception page");
            app.UseDeveloperExceptionPage();
        }
        
        app.UseStaticFiles();
        app.UseHttpsRedirection();
        app.UseRouting();

        app.ConfigureSwagger(_configuration);
        
        app.UseAuthorization();

        app.MapControllers();
    }
}
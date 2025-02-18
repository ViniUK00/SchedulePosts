namespace SchedulePosts.API.Configurations;

public static class SwaggerExtension
{
    public static void ConfigureSwagger(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSwaggerGen(options =>
        {
            //add oauth2 });
        });

        
    }

    public static void ConfigureSwagger(this IApplicationBuilder app, IConfiguration configuration)
    {
        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "SchedulePosts API v1");
            options.RoutePrefix = string.Empty;
        });
    }
}
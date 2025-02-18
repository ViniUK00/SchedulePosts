using System.Diagnostics;
using Serilog;

namespace SchedulePosts.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            bool isDevelopment = builder.Environment.IsDevelopment();

            if (Debugger.IsAttached)
            {
                builder.Configuration.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            }
            
            var startup = new Startup(builder.Configuration, isDevelopment);
            
            startup.ConfigureServices(builder.Services);
            
            var app = builder.Build();
            
            startup.Configure(app, app.Environment);
            Log.Information("Starting web host");
            
            app.Run();
        }
    }
    
}


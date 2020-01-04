using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WebApplication3.Settings;

namespace WebApplication3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var services = new ServiceCollection();

            //var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            //var builder = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile($"appsettings.{environmentName}.json", optional: false, reloadOnChange: true)
            //    .AddUserSecrets<SecureSettings>()
            //    .AddEnvironmentVariables();

            //IConfiguration configuration = builder.Build();

            //var secureSettings = configuration.GetSection("SecureSettings");
            //services.Configure<SecureSettings>(secureSettings);



            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)            
                .UseStartup<Startup>();
    }
}

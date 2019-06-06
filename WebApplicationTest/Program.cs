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
using WebStore.DB;

namespace WebApplicationTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var Host = CreateWebHostBuilder(args);

            using(var scope = Host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                
                try
                {
                    WebStoreContext Context = services.GetRequiredService<WebStoreContext>();
                    DBInitializer.Initialize(Context);
                }

                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while seeding the database.");
                }
            }

            Host.Run();
        }

        public static IWebHost CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>().Build();
    }
}

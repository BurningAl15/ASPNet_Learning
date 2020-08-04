using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using holaMundo.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace holaMundo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            var host=CreateHostBuilder(args).Build();

            using(var scope=host.Services.CreateScope()){
                var servicios=scope.ServiceProvider;

                try{
                    var context=servicios.GetRequiredService<EscuelaContext>();
                    context.Database.EnsureCreated();
                }catch(Exception e){
                    var logger=servicios.GetRequiredService<ILogger>();
                    logger.LogError(e,"An error occurred creating the database");
                }
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

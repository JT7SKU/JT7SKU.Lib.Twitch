using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Orleans;
using Orleans.Hosting;
using Services.Kirjasto.Unit.Twitch.Grains;

namespace Services.Kohdistuma.Unit.Twitch.OData
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
            .UseOrleans(builder =>
            {
               
                builder.AddMemoryGrainStorageAsDefault();
                builder.AddDynamoDBGrainStorage(
                    name: "profilestore", configureOptions: options =>
                    {
                        options.AccessKey = "test";
                        options.SecretKey = "test";
                        options.Service = "EU-West-2";

                    });
            })

                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        }
    }
}

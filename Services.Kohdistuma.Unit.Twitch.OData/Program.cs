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

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .UseOrleans(builder =>
            {
                builder.ConfigureApplicationParts(manager =>
                {
                    manager.AddApplicationPart(typeof(ChannelGrain).Assembly).WithReferences();
                });
                builder.AddMemoryGrainStorageAsDefault();
                builder.AddDynamoDBGrainStorage(
                    name: "profilestore",configureOptions: options=>
                    {
                        options.UseJson = true;

                    });
            })
                
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Orleans.Configuration;
using System;
using Orleans.Hosting;
using Orleans;
using System.Threading.Tasks;
using System.Net;
using Services.Kirjasto.Unit.Twitch.Grains;

namespace StreamKomponentsUnit.Twitch.Services
{
   public class Program
    {
         
        public static async Task<int> Main(string[] args)
        {
            try
            {
                var host = new HostBuilder()
                    .UseOrleans((context, siloBuilder) =>
                    {
                    siloBuilder.UseLocalhostClustering()
                        .Configure<ClusterOptions>(options => {
                            options.ClusterId = "dev";
                            options.ServiceId = "TwitchDevApp";
                            })
                        .Configure<EndpointOptions>(options => options.AdvertisedIPAddress = IPAddress.Loopback)
                        .ConfigureApplicationParts(parts => parts.AddApplicationPart(typeof(TwitchAccount).Assembly).WithReferences());
                })
                .ConfigureLogging(logging => logging.AddConsole())
                    .Build();
                await host.RunAsync();
                return 0;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                return 0;
            }
        }
    }
}

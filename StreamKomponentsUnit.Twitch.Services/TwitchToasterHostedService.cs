using Services.Kirjasto.Unit.Twitch.Interfaces;
using JT7SKU.Lib.Twitch;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Orleans.Runtime;
using Orleans;
using Microsoft.Extensions.Hosting;
using System.Threading;

namespace StreamKomponentsUnit.Twitch.Services
{
    public class TwitchToasterHostedService : IHostedService
    {
        public Task StartAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

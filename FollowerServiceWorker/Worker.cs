using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Orleans;
using Orleans.Concurrency;
using Services.Kirjasto.Unit.Twitch.Interfaces;

namespace FollowerServiceWorker
{
    [StatelessWorker]
    public class Worker :  BackgroundService, IFollowerWorkerGrain
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        public Task AddFollower(ITwitchFollower twitchFollower)
        {
            throw new NotImplementedException();
        }

        public Task RemoveFollower(ITwitchFollower twitchFollower)
        {
            throw new NotImplementedException();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}

using JT7SKU.Lib.Twitch;
using Orleans;
using Services.Kirjasto.Unit.Twitch.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Kirjasto.Unit.Twitch.Grains
{
    public class SubscriberGrain :Grain, ITwitchSubscriber
    {
        public override async Task OnActivateAsync(CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
        }
        public Task NewSubscriber(User user,Message message)
        {
            throw new NotImplementedException();
        }
    }
}

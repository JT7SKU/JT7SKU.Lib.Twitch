using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using JT7SKU.Lib.Twitch;
using Orleans;
using Services.Kirjasto.Unit.Twitch.Interfaces;

namespace Services.Kirjasto.Unit.Twitch.Grains
{
    public class CheererGrain : Grain, ITwitchCheer
    {
        public override Task OnActivateAsync()
        {
            return base.OnActivateAsync();
        }
        public Task NewCheer(Message message)
        {
            throw new NotImplementedException();
        }
    }
}

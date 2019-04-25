using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using JT7SKU.Lib.Twitch.Interfaces;
using Orleans;

namespace JT7SKU.Lib.Twitch.Grains
{
    public class CheererGrain : Grain,ITwitchCheer
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

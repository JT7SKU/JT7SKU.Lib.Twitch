using JT7SKU.Lib.Twitch.Interfaces;
using Orleans;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Grains
{
    public class SubscriberGrain :Grain, ITwitchSubscriber
    {
        public override Task OnActivateAsync()
        {
            return base.OnActivateAsync();
        }
        public Task NewSubscriber(User user,Message message)
        {
            throw new NotImplementedException();
        }
    }
}

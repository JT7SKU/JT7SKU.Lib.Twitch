using JT7SKU.Lib.Twitch;
using Orleans;
using Orleans.Providers;
using Services.Kirjasto.Unit.Twitch.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Kirjasto.Unit.Twitch.Grains
{
    [StorageProvider(ProviderName="Channel")]
    public class ChannelGrain : Grain<ChannelState> , ITwitchChannel
    {
        private Channel Channel; 
    }
    public class ChannelState
    {
        public bool IsLive { get; set; }

        public Dictionary<string, ITwitchSubscriber> Subscriptions { get; set; }
        public Dictionary<string, ITwitchFollower> Followers { get; set; }
    }
}

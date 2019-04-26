using JT7SKU.Lib.Twitch.Interfaces;
using Orleans;
using Orleans.Providers;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT7SKU.Lib.Twitch.Grains
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

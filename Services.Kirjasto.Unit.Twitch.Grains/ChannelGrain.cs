using JT7SKU.Lib.Twitch;
using Microsoft.Extensions.Logging;
using Orleans;
using Orleans.Providers;
using Services.Kirjasto.Unit.Twitch.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Kirjasto.Unit.Twitch.Grains
{
    [StorageProvider(ProviderName="Channel")]
    public class ChannelGrain : Grain<ChannelState> , ITwitchChannel
    {
        private Channel Channel;
        private readonly ILogger<ChannelGrain> logger;
        private string GrainType => nameof(ChannelGrain);
        private string GrainKey => this.GetPrimaryKeyString();
        public ChannelGrain(ILogger<ChannelGrain> logger)
        {
            this.logger = logger;
        }
        
        public override Task OnActivateAsync()
        {
            this.State.IsLive = true;
            this.State.Subscriptions = new Dictionary<string, ITwitchSubscriber>();
            this.State.Followers = new Dictionary<string, ITwitchFollower>();
            return base.OnActivateAsync();
        }
    }
    public class ChannelState
    {
        public bool IsLive { get; set; }

        public Dictionary<string, ITwitchSubscriber> Subscriptions { get; set; }
        public Dictionary<string, ITwitchFollower> Followers { get; set; }
    }
}

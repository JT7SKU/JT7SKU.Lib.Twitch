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
        private readonly HashSet<ITwitchViewer> viewers = new HashSet<ITwitchViewer>();
        private string GrainType => nameof(ChannelGrain);
        private string GrainKey => this.GetPrimaryKeyString();
        public ChannelGrain(ILogger<ChannelGrain> logger)
        {
            this.logger = logger;
        }
        
        public  async Task OnActivateAsync()
        {
            this.State.IsLive = true;
            this.State.Subscriptions = new Dictionary<string, ITwitchSubscriber>();
            this.State.Followers = new Dictionary<string, ITwitchFollower>();
            await Task.CompletedTask;
        }

        #region Viewer portion

        public Task SubscribeAsync(ITwitchViewer viewer)
        {
            this.viewers.Add(viewer);
            return Task.CompletedTask;
        }

        public Task UnSubscribeAsync(ITwitchViewer viewer)
        {
            this.viewers.Remove(viewer);
            return Task.CompletedTask;
        }

        public Task FollowAsync(ITwitchViewer viewer)
        {
            this.viewers.Add(viewer);
            return Task.CompletedTask;
        }

        public Task UnFollowAsync(ITwitchViewer viewer)
        {
            this.viewers.Remove(viewer);
            return Task.CompletedTask;
        }
        #endregion 
    }
    public class ChannelState
    {
        public bool IsLive { get; set; }

        public Dictionary<string, ITwitchSubscriber> Subscriptions { get; set; }
        public Dictionary<string, ITwitchFollower> Followers { get; set; }
    }
}

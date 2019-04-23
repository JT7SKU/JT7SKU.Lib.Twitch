using JT7SKU.Lib.Twitch.Interfaces;
using Microsoft.Extensions.Logging;
using Orleans;
using Orleans.Concurrency;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Grains
{
    [Reentrant]
    public class TwitchAccount : Grain<TwitchAccountState>, ITwitchAccount
    {
        private const int ReceivedMessageCacheSize = 100;
        private const int PublishedMessageCacheSize = 100;
        private readonly ILogger<TwitchAccount> logger;
        private const int MAX_MESSAGE_LENGHT = 280;
        private Task outstandingWriteStateOperation;
        private readonly HashSet<ITwitchViewer> viewers = new HashSet<ITwitchViewer>();
        public TwitchAccount(ILogger<TwitchAccount> logger) => this.logger = logger;

        private string GrainType => nameof(TwitchAccount);
        private string GrainKey => this.GetPrimaryKeyString();
        #region Grain overrides
        public override Task OnActivateAsync()
        {
            if (this.State.RecentReceiveMessages == null) this.State.RecentReceiveMessages = new Queue<Message>(ReceivedMessageCacheSize);
            if (this.State.MyPublishedMessages == null) this.State.MyPublishedMessages = new Queue<Message>(PublishedMessageCacheSize);
            if (this.State.Followers == null) this.State.Followers = new Dictionary<string, ITwitchFollower>();
            if (this.State.Subscriptions == null) this.State.Subscriptions = new Dictionary<string, ITwitchSubscriber>();
            if (this.State.Broadcasters == null) this.State.Broadcasters = new Dictionary<string, ITwitchBroadcaster>();
            this.logger.LogInformation($"{this.GrainType}{this.GrainKey} activated.");
            return Task.CompletedTask;
        }
        #endregion
        #region ITwitchAccountGrain interface methods
        public async Task FollowUserIdAsync(string username)
        {
            this.logger.LogInformation($"{this.GrainType}{this.GrainKey} > FollowUserName({username})");
            var userToFollow = this.GrainFactory.GetGrain<ITwitchBroadcaster>(username);
            await userToFollow.AddFollowerAsync(this.GrainKey, this.AsReference<ITwitchFollower>());
           /// this.State.Followers[username] = userToFollow;
            await this.WriteStateAsync();
            this.viewers.ForEach(_ => _.FollowerAdded(username));            
        }

        public void NewBroadcast(Message message)
        {
            throw new NotImplementedException();
        }

        public async Task UnFollowUserIdAsync(string username)
        {
            this.logger.LogInformation($"{this.GrainType}{this.GrainKey} > UnFollowUserName({username})");
            await GrainFactory.GetGrain<ITwitchBroadcaster>(username).RemoveFollowerAsync(this.GrainKey);
            this.State.Followers.Remove(username);
            await this.WriteStateAsync();
            this.viewers.ForEach(_ =>_.FollowerRemoved(username));
        }

        public async Task AddFollowerAsync(string username, ITwitchFollower follower)
        {
            this.State.Followers[username] = follower;
            await this.WriteStateAsync();
        }

        public async Task RemoveFollowerAsync(string username)
        {
            this.State.Followers.Remove(username);
            await this.WriteStateAsync();
        }

        public async Task AddSubscriberAsync(string username, ITwitchSubscriber subscriber)
        {
            this.State.Subscriptions[username]=subscriber;
            await this.WriteStateAsync();
        }

        public async Task RemoveSubscriberAsync(string username)
        {
            this.State.Subscriptions.Remove(username);
            await this.WriteStateAsync();
        }

        public async Task<ImmutableList<Message>> GetReceivedWhispersAsync(int n = 10, int start = 0) 
        {
            throw new NotImplementedException();
        }

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

        public Task<ImmutableList<string>> GetFollowersListAsync() => Task.FromResult(this.State.Followers.Keys.ToImmutableList());

        public Task<ImmutableList<string>> GetSubscribersListAsync() => Task.FromResult(this.State.Subscriptions.Keys.ToImmutableList());

        public Task<ImmutableList<string>> GetBitsCheeredListAsync() => Task.FromResult(this.State.Cheers.Keys.ToImmutableList());

        public Task<ImmutableList<string>> GetTipsListAsync() => Task.FromResult(this.State.Tips.Keys.ToImmutableList());

        public void NewSubscriber(Message message)
        {
            throw new NotImplementedException();
        }

        public void NewFollower(Message message)
        {
            throw new NotImplementedException();
        }
        #endregion
        private Message CreateNewTwitchMessage(string message) => new Message {Context = message, UserId= this.GrainKey, Timestamp= DateTime.Now };
        protected override async Task WriteStateAsync()
        {
            var currentWriteStateOperation = this.outstandingWriteStateOperation;
            if(currentWriteStateOperation != null)
            {
                try
                {
                    await currentWriteStateOperation;
                }
                catch (Exception)
                {

                } 
                finally
                {
                    if(this.outstandingWriteStateOperation == currentWriteStateOperation)
                    {
                        this.outstandingWriteStateOperation = null;
                    }
                }
            }
            if (this.outstandingWriteStateOperation == null)
            {
                currentWriteStateOperation = base.WriteStateAsync();
                this.outstandingWriteStateOperation = currentWriteStateOperation;
            }
            else
            {
                currentWriteStateOperation = this.outstandingWriteStateOperation;
            }
            try
            {
                await currentWriteStateOperation;
            }            
            finally
            {
                if(this.outstandingWriteStateOperation == currentWriteStateOperation)
                {
                    this.outstandingWriteStateOperation = null;
                }
            }
        }
    }
    public class TwitchAccountState
    {
        public Dictionary<string, ITwitchBroadcaster> Broadcasters { get; set; }
        public Dictionary<string, ITwitchSubscriber> Subscriptions { get; set; }
        public Dictionary<string, ITwitchFollower> Followers { get; set; }
        public Dictionary<string, ITwitchCheer> Cheers { get; set; }
        public Dictionary<string, ITwitchTip> Tips { get; set; }

        public Queue<Message> RecentReceiveMessages { get; set; }
        public Queue<Message> MyPublishedMessages { get; set; }
    }
}

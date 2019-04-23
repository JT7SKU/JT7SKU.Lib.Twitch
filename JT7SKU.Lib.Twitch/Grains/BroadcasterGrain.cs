using System;
using JT7SKU.Lib.Twitch.Interfaces;
using System.Collections.Generic;
using System.Text;
using System.Collections.Immutable;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Grains
{
    public class BroadcasterGrain : ITwitchBroadcaster
    {
        public Task AddFollowerAsync(string username, ITwitchFollower follower)
        {
            throw new NotImplementedException();
        }

        public Task AddSubscriberAsync(string username, ITwitchSubscriber subscriber)
        {
            throw new NotImplementedException();
        }

        public Task<ImmutableList<string>> GetBitsCheeredListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ImmutableList<string>> GetFollowersListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ImmutableList<string>> GetSubscribersListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ImmutableList<string>> GetTipsListAsync()
        {
            throw new NotImplementedException();
        }

        public void NewBroadcast(Message message)
        {
            throw new NotImplementedException();
        }

        public Task RemoveFollowerAsync(string username)
        {
            throw new NotImplementedException();
        }

        public Task RemoveSubscriberAsync(string username)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading.Tasks;
using JT7SKU.Lib.Twitch;
using Orleans;

namespace Services.Kirjasto.Unit.Twitch.Interfaces
{
    public interface ITwitchBroadcaster : IGrainWithStringKey
    {
        void NewBroadcast(Message message);
        Task AddFollowerAsync(string username, ITwitchFollower follower);
        Task RemoveFollowerAsync(string username);

        Task AddSubscriberAsync(string username, ITwitchSubscriber subscriber);
        Task RemoveSubscriberAsync(string username);
        Task<ImmutableList<string>> GetFollowersListAsync();
        Task<ImmutableList<string>> GetSubscribersListAsync();
        Task<ImmutableList<string>> GetBitsCheeredListAsync();
        Task<ImmutableList<string>> GetTipsListAsync();
    }
}

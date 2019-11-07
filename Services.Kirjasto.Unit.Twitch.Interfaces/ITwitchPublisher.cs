using JT7SKU.Lib.Twitch;
using Orleans;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading.Tasks;

namespace Services.Kirjasto.Unit.Twitch.Interfaces
{
    public interface ITwitchPublisher: IGrainWithStringKey
    {
        Task<ImmutableList<Message>> GetPublishedMessagesAsync(int n = 10, int start = 0);
        Task AddFollowerAsync(string username, ITwitchFollower follower);
        Task RemoveFollowerAsync(string username, ITwitchFollower follower);
    }
}

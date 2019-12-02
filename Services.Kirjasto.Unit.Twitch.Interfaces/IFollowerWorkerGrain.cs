using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Kirjasto.Unit.Twitch.Interfaces
{
    public interface IFollowerWorkerGrain
    {
        Task AddFollower(ITwitchFollower twitchFollower);
        Task RemoveFollower(ITwitchFollower twitchFollower);
    }
}

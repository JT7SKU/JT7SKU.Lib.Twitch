using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Orleans;
namespace Services.Kirjasto.Unit.Twitch.Interfaces
{
    public interface ITwitchChannel : IGrainWithIntegerKey
    {
        Task SubscribeAsync(ITwitchViewer viewer);
        Task UnSubscribeAsync(ITwitchViewer viewer);
        Task FollowAsync(ITwitchViewer viewer);
        Task UnFollowAsync(ITwitchViewer viewer);
    }
}

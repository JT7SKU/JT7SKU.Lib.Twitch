using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Immutable;

namespace JT7SKU.Lib.Twitch.Interfaces
{
   public interface ITwitchAccount : ITwitchPublisher, ITwitchSubscriber
    {
        Task FollowUserIdAsync(string userNameToFollow);
        Task UnFollowUserIdAsync(string userNameToFollow);
        Task<ImmutableList<Message>> GetReceivedWhispersAsync(int n = 10, int start = 0);
        Task SubscribeAsync(ITwitchViewer viewer);
        Task UnSubscribeAsync(ITwitchViewer viewer);
        Task FollowAsync(ITwitchViewer viewer);
        Task UnFollowAsync(ITwitchViewer viewer);
        Task PublishMessageAsync(string message);
    }
}

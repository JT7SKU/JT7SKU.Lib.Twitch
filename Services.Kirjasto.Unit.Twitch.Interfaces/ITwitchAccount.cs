using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Immutable;
using JT7SKU.Lib.Twitch;

namespace Services.Kirjasto.Unit.Twitch.Interfaces
{
   public interface ITwitchAccount : ITwitchPublisher, ITwitchSubscriber
    {
        Task FollowUserIdAsync(string userNameToFollow);
        Task UnFollowUserIdAsync(string userNameToFollow);
        Task<ImmutableList<Message>> GetReceivedWhispersAsync(int n = 10, int start = 0);
      
        Task PublishMessageAsync(string message);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Chat
{
    public class ChannelChatClearEvent
    {
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUsername { get; set; }
        public string BroadcasterUserLogin { get; set; }
    }
}

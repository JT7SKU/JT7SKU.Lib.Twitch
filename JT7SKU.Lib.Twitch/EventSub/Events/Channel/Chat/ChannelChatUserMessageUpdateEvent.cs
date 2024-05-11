using JT7SKU.Lib.Twitch.Models;
using JT7SKU.StreamService.KirjastoUtility.Twitch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Chat
{
    public class ChannelChatUserMessageUpdateEvent
    {
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserName { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public string ChatterUserId { get; set; }
        public string ChatterUserName { get; set; }
        public string ChatterUserLogin { get; set; }
        public ChatMessageStatus Status { get; set; }
        public string MessageId { get; set; }
        public ChatMessage Message { get; set; }
    }
}

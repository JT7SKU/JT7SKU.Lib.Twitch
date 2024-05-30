using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JT7SKU.Lib.Twitch.Models;
using JT7SKU.StreamService.KirjastoUtility.Twitch.Models;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Chat
{
    public class ChannelChatMessageEvent
    {
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserName { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public string ChatterUserId { get; set; }
        public string ChatterUserName { get; set; }
        public string ChatterUserLogin { get; set; }
        public string MessageId { get; set; }
        public ChatMessage Message { get; set; }
        public ChatMessageType MessageType { get; set; }
        public ChatBadges Badges { get; set; }
        public ChatCheer Cheer { get; set; }
        public string Color { get; set; }
        public ChatReply Reply { get; set; }
        public string ChannelPointsCustomRewardsId { get; set; }
        public string ChannelPointsAnimationId { get; set; }
    }
}

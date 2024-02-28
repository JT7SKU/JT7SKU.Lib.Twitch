using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JT7SKU.Lib.Twitch.Models;

namespace JT7SKU.Lib.Twitch.EventSub.Events.Channel
{
    public class ChannelChatMessageEvent
    {
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserName { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public string ChatterUserId { get; set; }
        public string ChatterUserName { get; set;}
        public string ChatterUserLogin { get; set; }
        public string MessageId { get; set; }
        public ChatMessage Message { get; set; }
        public string MessageType { get; set; }
        public ChatBadges Badges { get; set; }
        public ChatCheer Cheer { get; set; }
        public string Color { get; set; }
        public ChatReply Reply { get; set; }
        public string ChannelPointsCustomRewardsId { get; set; }
    }
}

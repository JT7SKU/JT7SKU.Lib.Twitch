using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Moderation
{
    public class ChannelUnbanRequestCreateEvent
    {
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserName { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserLogin { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

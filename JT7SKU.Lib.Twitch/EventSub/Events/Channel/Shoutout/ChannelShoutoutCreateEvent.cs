using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Shoutout
{
    public class ChannelShoutoutCreateEvent
    {
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserName { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public string ModeratorUserId { get; set; }
        public string ModeratorUserName { get; set; }
        public string ModeratorUserLogin { get; set; }
        public string ToBroadcasterUserId { get; set; }
        public string ToBroadcasterLogin { get; set; }
        public string ToBroadcasterUserName { get; set; }
        public DateTime StartedAt { get; set; }
        public int ViewerCount { get; set; }
        public DateTime CooldownEndsAt { get; set; }
        public DateTime TargetCooldownEndsAt { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.GuestStar
{
    public class ChannelGuestStarSessionEndEvent
    {
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserName { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public string SessionId { get; set; }
        public string StartedAt { get; set; }
        public string EndedAt { get; set; }
        public string HostUserId { get; set; }
        public string HostUserName { get; set; }
        public string HostUserLogin { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.SuspiciousUser
{
    public class ChannelSuspiciousUserMessageEvent
    {
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public string BroadcasteruserName { get; set; }
        public string ModeratorUserId { get; set; }
        public string ModeratorUserName { get; set; }
        public string ModeratorUserLogin { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserLogin { get; set; }
        public string LowTrustStatus { get; set; }
    }
}

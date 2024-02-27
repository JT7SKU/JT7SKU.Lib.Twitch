using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Events.Channel
{
    public class ChannelBanEvent
    {
        public string UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserName { get; set; }
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public string BroadcasterUserName { get; set; }
        public string ModeratorUserId { get; set; }
        public string ModeratorUserLogin { get; set; }
        public string ModeratorUserName { get; set;}
        public string Reason { get; set; }
        public string BannedAt { get; set; }
        public string EndsAt { get; set; }
        public bool IsPermanent { get; set; }
    }
}

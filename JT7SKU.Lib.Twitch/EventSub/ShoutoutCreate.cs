using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub
{
    public class ShoutoutCreate
    {
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public string BroadcasterUserName { get; set; }
        public string ToBroadcasterUserId { get; set; }
        public string ToBroadcasterUserLogin { get; set; }
        public string ToBroadcasterUserName { get; set; }
        public string ModeratorUserId { get; set; }
        public string ModeratorUserLogin { get; set; }
        public string ModeratorUserName { get; set; }
        public int ViewerCount { get; set; }
        public string StartedAt { get; set; }
        public string CooldownEndsAt { get; set; }
        public string TargetCooldownEndsAt { get; set; }
    }
}

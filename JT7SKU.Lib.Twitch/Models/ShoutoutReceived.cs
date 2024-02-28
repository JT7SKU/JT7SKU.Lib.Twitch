using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Models
{
    public class ShoutoutReceived
    {
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public string BroadcasterUserName { get; set; }
        public string FromBroadcasterUserId { get; set; }
        public string FromBroadcasterUserLogin { get; set; }
        public string FromBroadcasterUserName { get; set; }
        public int ViewerCount { get; set; }
        public string StartedAt { get; set; }
    }
}

using JT7SKU.StreamService.KirjastoUtility.Twitch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Moderation
{
    public class ChannelUnbanRequestResolveEvent
    {
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserName { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserLogin { get; set; }
        public string ResolutionText { get; set; }
        public UnbanRequestStatus Status { get; set; }
    }
}

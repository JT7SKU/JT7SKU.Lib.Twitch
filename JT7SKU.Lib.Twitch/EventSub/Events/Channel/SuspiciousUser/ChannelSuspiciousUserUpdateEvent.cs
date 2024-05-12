using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.SuspiciousUser
{
    public class ChannelSuspiciousUserUpdateEvent
    {
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserName { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserLogin { get; set; }
        public string[] SharedBanChannelIds { get; set; }
        public string[] Types { get; set; }
        public string BanEvasionEvaluation { get; set; }
        public ChatMessage Message { get; set; }
        
    }
}

using JT7SKU.Lib.Twitch.Models;
using JT7SKU.StreamService.KirjastoUtility.Twitch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Events.Automod
{
    public class AutomodMessageUpdateEvent
    {
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public string BroadcasterUserName { get; set; }
        public string UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserName { get; set; }
        public string ModeratorUserId { get; set; }
        public string ModeratorUserName { get; set; }
        public string ModeratorUserLogin { get; set; }
        public string MessageId { get; set; }
        public ChatMessage Message { get; set; }
        public string Category { get; set; }
        public int Level { get; set; }
        public ChatMessageStatus Status { get; set; }
        public DateTime HeldAt { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Chat
{
    public class ChannelChatSettingsUpdateEvent
    {
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserName { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public bool EmoteMode { get; set; }
        public bool FollowerMode { get; set; }
        public int FollowerModeDurationMinutes { get; set; }
        public bool SlowMode { get; set; }
        public int SlowModeWaitTimeSeconds { get; set; }
        public bool SubscriberMode { get; set; }
        public bool UniqueChatMode { get; set; }
    }
}

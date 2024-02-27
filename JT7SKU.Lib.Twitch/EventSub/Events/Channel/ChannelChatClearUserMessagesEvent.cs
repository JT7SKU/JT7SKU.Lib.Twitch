using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Events.Channel
{
    public class ChannelChatClearUserMessagesEvent
    {
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUsername { get; set; }
        public string BroadcasterLogin { get; set; }
        public string TargetUserId { get; set; }
        public string TargetUsername { get; set; }
        public string TargetUserLogin { get; set; }
    }
}

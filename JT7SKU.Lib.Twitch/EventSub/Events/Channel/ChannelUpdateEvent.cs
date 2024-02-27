using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Events.Channel
{
    public class ChannelUpdateEvent
    {
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserName { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string[] ContentClassificationLabels { get; set; }
    }
}

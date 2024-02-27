using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Events.Channel
{
    public class ChannelPredictionBeginEvent
    {
        public string Id { get; set; }
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public string BroadcasteruserName { get; set; }
        public string Title { get; set; }
        public OutComes OutComes { get; set; }
        public string StartedAt { get; set; }
        public string LocksAt { get; set; }
    }
}

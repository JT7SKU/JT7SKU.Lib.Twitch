using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JT7SKU.Lib.Twitch.EventSub;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Prediction
{
    public class ChannelPredictionEndEvent
    {
        public string Id { get; set; }
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public string BroadcasteruserName { get; set; }
        public string Title { get; set; }
        public OutComes OutComes { get; set; }
        public string Status { get; set; }
        public string StartedAt { get; set; }
        public string EndedAt { get; set; }
    }
}

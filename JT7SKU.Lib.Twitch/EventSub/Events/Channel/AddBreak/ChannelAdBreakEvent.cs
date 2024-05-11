using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.AddBreak
{
    public class ChannelAdBreakEvent
    {
        public int DurationSeconds { get; set; }
        public string StartedAt { get; set; }
        public bool IsAutomatic { get; set; }
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public string BroadcasterUsername { get; set; }
        public string RequesterUserId { get; set; }
        public string RequesterUserLogin { get; set; }
        public string RequesterUsername { get; set; }

    }
}

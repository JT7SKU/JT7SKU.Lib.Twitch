using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Conditions.Channel
{
    public class ChannelRaidCondition
    {
        public string FromBroadcasterUserId { get; set; }
        public string ToBroadcasterUserId { get; set; }
    }
}

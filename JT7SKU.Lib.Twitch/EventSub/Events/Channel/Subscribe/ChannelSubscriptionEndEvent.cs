using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JT7SKU.Lib.Twitch.Models;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Subscribe
{
    public class ChannelSubscriptionEndEvent
    {
        public string UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserName { get; set; }
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public string BroadcasterUserName { get; set; }
        public SubscriberType Tier { get; set; }
        public bool IsGift { get; set; }
    }
}

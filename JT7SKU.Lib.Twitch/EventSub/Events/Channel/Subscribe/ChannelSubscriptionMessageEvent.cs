﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JT7SKU.Lib.Twitch.Models;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Subscribe
{
    public class ChannelSubscriptionMessageEvent
    {
        public string UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserName { get; set; }
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public string BroadcasterUserName { get; set; }
        public SubscriberType Tier { get; set; }
        public ChatMessage Message { get; set; }
        public int CumulativeMonths { get; set; }
        public int StreakMonths { get; set; }
        public int DurationMonths { get; set; }
    }
}

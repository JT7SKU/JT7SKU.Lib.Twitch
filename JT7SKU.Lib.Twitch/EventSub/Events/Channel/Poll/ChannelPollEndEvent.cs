﻿using JT7SKU.Lib.Twitch.EventSub;
using JT7SKU.Lib.Twitch.EventSub.Conditions.Channel;
using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Poll
{
    public class ChannelPollEndEvent
    {
        public string Id { get; set; }
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserName { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public string Title { get; set; }
        public Choices Choices { get; set; }
        public BitsVoting BitsVoting { get; set; }
        public ChannelPointsVoting ChannelPointsVoting { get; set; }
        public string StartedAt { get; set; }
        public string EndsAt { get; set; }
    }
}

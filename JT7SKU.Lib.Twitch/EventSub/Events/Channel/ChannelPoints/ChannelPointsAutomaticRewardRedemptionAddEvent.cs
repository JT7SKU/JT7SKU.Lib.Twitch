﻿using JT7SKU.Lib.Twitch;
using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.ChannelPoints
{
    public class ChannelPointsAutomaticRewardRedemptionAddEvent
    {
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserName { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserLogin { get; set; }
        public string Id { get; set; }
        public Reward Reward { get; set; }
        public Message Message { get; set; }
        public string UserInput { get; set; }
        public DateTime RedeemedAt { get; set; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JT7SKU.Lib.Twitch.Models;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.ChannelPoints
{
    public class ChannelPointsCustomRewardRedemptionAddEvent
    {
        public string Id { get; set; }
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserName { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserLogin { get; set; }
        public string UserInput { get; set; }
        public string Status { get; set; }
        public Reward Reward { get; set; }
        public string RedeemedAt { get; set; }
    }
}
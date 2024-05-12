using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JT7SKU.Lib.Twitch.EventSub;
using JT7SKU.Lib.Twitch.Models;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.ChannelPoints
{
    public class ChannelPointsCustomRewardsRemoveEvent
    {
        public string Id { get; set; }
        public string BroadcasterUserId { get; set; }
        public string BroadcasterUserName { get; set; }
        public string BroadcasterUserLogin { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsPaused { get; set; }
        public bool IsInStock { get; set; }
        public string Title { get; set; }
        public int Cost { get; set; }
        public string Prompt { get; set; }
        public bool IsUserInPutRequired { get; set; }
        public bool ShouldRedemptionsSkipRequestQueue { get; set; }
        public MaxPerStream MaxPerStream { get; set; }
        public MaxPerUserPerStream MaxPerUserPerStream { get; set; }
        public string BackgroundColor { get; set; }
        public Image Image { get; set; }
        public Image DefaultImage { get; set; }
        public GlobalCooldown GlobalCooldown { get; set; }
        public string CooldownExpiresAt { get; set; }
        public int RedemptionsRedeemedCurrentStream { get; set; }
    }
}

using JT7SKU.Lib.Twitch.EventSub.Conditions.Channel;
using JT7SKU.Lib.Twitch.EventSub.Events.Channel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel
{
    internal class Raid
    {
    }
    #region Channel.Raid
    // The channel.raid subscription type sends a notification when a broadcaster raids another broadcaster’s channel.
    public record ChannelRaidRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelRaidCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelRaidNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelRaidEvent Event { get; set; }
    }
    #endregion
}

using JT7SKU.Lib.Twitch.EventSub.Conditions.Channel;
using JT7SKU.Lib.Twitch.EventSub.Events.Channel;
using System.ComponentModel.DataAnnotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel
{
    internal class Cheer
    {
    }
    #region Channel.Cheer
    // The channel.cheer subscription type sends a notification when a user cheers on the specified channel.
    // Must have bits:read scope.
    public record ChannelCheerRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelCheerCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelCheerNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelCheerEvent Event { get; set; }
    }
    #endregion
}

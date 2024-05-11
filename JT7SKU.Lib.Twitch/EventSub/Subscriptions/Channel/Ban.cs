using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Channel.Moderation;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Moderation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel
{
    internal class Ban
    {
    }
    #region Channel.Ban
    // The channel.ban subscription type sends a notification when a viewer is timed out or banned from the specified channel.
    // Must have channel:moderate scope.
    public record ChannelBanRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelBanCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelBanNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelBanEvent Event { get; set; }
    }
    #endregion
}

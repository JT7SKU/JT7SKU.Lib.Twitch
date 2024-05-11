using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Channel.Subscribe;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Subscribe;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel.Subscription
{
    internal class End
    {
    }
    #region Channel.Subscription.End
    // The channel.subscription.end subscription type sends a notification when a subscription to the specified channel expires.
    // Must have channel:read:subscriptions scope.
    public record ChannelSubscriptionEndRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelSubscriptionEndCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelSubscriptionEndNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelSubscriptionEndEvent Event { get; set; }
    }
    #endregion
}

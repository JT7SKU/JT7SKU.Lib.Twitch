using JT7SKU.Lib.Twitch.EventSub.Conditions.Channel;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Subscribe;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel.Subscription
{
    internal class Gift
    {
    }
    #region Channel.Subscrption.Gift
    // The channel.subscription.gift subscription type sends a notification when a user gives one or more gifted subscriptions in a channel.
    // Must have channel:read:subscriptions scope.
    public record ChannelSubscriptionGiftRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelSubscriptionGiftEvent Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelSubscriptionGiftNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelSubscriptionGiftEvent Event { get; set; }
    }
    #endregion
}

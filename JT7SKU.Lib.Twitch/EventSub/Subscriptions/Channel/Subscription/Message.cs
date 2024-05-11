using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Subscribe;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel.Subscription
{
    internal class Message
    {
    }
    #region Channel.Subscription.Message
    // The channel.subscription.message subscription type sends a notification when a user sends a resubscription chat message in a specific channel.
    // Must have channel:read:subscriptions scope.
    public record ChannelSubscriptionMessageRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelSubscriptionMessageEvent Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelSubscriptionMessageNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelSubscriptionMessageEvent Event { get; set; }
    }
    #endregion
}

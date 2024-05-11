using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Channel.Subscribe;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Subscribe;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel
{
    internal class Subscribe
    {
    }
    #region Channel.Subscribe
    // The channel.subscribe subscription type sends a notification when a specified channel receives a subscriber. This does not include resubscribes.
    // Must have channel:read:subscriptions scope.
    public record ChannelSubscribeRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelSubscribeCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelSubscribeNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelSubscribeEvent Event { get; set; }
    }
    #endregion
}

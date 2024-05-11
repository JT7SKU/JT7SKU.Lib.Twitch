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
    internal class Unban
    {
    }
    #region Channel.Unban
    // The channel.unban subscription type sends a notification when a viewer is unbanned from the specified channel.
    // Must have channel:moderate scope.
    public record ChannelUnbanRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelUnbanCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelUnbanNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelUnbanEvent Event { get; set; }
    }
    #endregion
}

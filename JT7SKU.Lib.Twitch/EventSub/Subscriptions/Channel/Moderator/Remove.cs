using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Channel.Moderation;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Moderation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel.Moderator
{
    internal class Remove
    {
    }
    #region Channel.Moderator.Remove
    // The channel.moderator.remove subscription type sends a notification when a user has moderator privileges removed on a specified channel.
    // Must have moderation:read scope.
    public record ChannelModeratorRemoveRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelModeratorRemoveCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelModeratorRemoveNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelModeratorRemoveEvent Event { get; set; }
    }
    #endregion
}

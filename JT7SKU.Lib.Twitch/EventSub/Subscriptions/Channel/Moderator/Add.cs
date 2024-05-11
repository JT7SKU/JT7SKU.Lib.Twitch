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
    internal class Add
    {
    }
    #region Channel.Moderater.Add
    // The channel.moderator.add subscription type sends a notification when a user is given moderator privileges on a specified channel.
    // Must have moderation:read scope.
    public record ChannelModeratorAddRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelModeratorAddContition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelModeratorAddNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelModeratorAddEvent Event { get; set; }
    }
    #endregion
}

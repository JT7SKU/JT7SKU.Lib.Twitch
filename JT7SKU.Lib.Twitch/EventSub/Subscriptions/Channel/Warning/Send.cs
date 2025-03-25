using JT7SKU.Lib.Twitch.EventSub;
using JT7SKU.Lib.Twitch.Models;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Channel.Warning;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Warning;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Subscriptions.Channel.Warning
{
    internal class Send
    {
    }
    #region channel.warning.send
    /// <summary>
    /// The channel.warning.send subscription type sends a notification when a warning is sent to a user. 
    /// Broadcasters and moderators can see the warning’s details.
    /// Authorization
    /// Must have the moderator:read:warnings or moderator:manage:warnings scope.
    /// </summary>
    public record ChannelWarningSendRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChanneWarningSendCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelWarningNotificationPayload
    {
        public Subscription Subscription { get; set; }
        public ChannelWarningSendEvent Event { get; set; }
    }
    #endregion
}

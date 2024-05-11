using JT7SKU.Lib.Twitch.EventSub.Conditions.Channel;
using JT7SKU.Lib.Twitch.EventSub.Events.Channel;
using JT7SKU.Lib.Twitch.Models;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Channel.Moderation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel
{
    internal class Moderate
    {
    }
    #region Channel.Moderate
    //  The channel.moderate subscription type sends a notification when a moderator performs a moderation action in a channel.
    /* Must have all of the following scopes:

    moderator:read:blocked_terms OR moderator:manage:blocked_terms
    moderator:read:chat_settings OR moderator:manage:chat_settings
    moderator:read:unban_requests OR moderator:manage:unban_requests
    moderator:read:banned_users OR moderator:manage:banned_users
    moderator:read:chat_messages OR moderator:manage:chat_messages
    moderator:read:moderators
    moderator:read:vips */
    public record ChannelModerateRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelModerateCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelModerateNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public Event Event { get; set; }
    }

    #endregion
}

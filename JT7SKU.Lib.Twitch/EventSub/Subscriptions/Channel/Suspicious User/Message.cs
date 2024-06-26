﻿using JT7SKU.Lib.Twitch.EventSub.Conditions.Channel;
using JT7SKU.Lib.Twitch.EventSub.Events.Channel;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Channel.SuspisiousUser;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.SuspiciousUser;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel.Suspicious_User
{
    internal class Message
    {
    }
    #region Channel.Suspicious User.Message
    // The channel.suspicious_user.message subscription type sends a notification when a chat message has been sent from a suspicious user.
    // Requires the moderator:read:suspicious_users scope.
    // If you use webhooks, the user in moderator_user_id must have granted your app (client ID) one of the above permissions prior
    // to your app subscribing to this subscription type.
    // To learn more, see the Authentication section of Create EventSub Subscription.
    // If you use WebSockets, the ID in moderator_user_id must match the user ID in the user access token.
    public record ChannelSuspiciousUserMessageRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelSuspiciousUserMessageCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelSuspiciousUserMessageNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelSuspiciousUserMessageEvent Event { get; set; }
    }
    #endregion
}

using JT7SKU.Lib.Twitch.EventSub.Conditions.Channel;
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
    internal class Update
    {
    }
    #region Channel.Suspicious User.Update
    //  The channel.suspicious_user.update subscription type sends a notification when a suspicious user has been updated.
    // Requires the moderator:read:suspicious_users scope.
    // If you use webhooks, the user in moderator_user_id must have granted your app (client ID) one of the above permissions prior to your app subscribing to this subscription type.
    // To learn more, see the Authentication section of Create EventSub Subscription.
    // If you use WebSockets, the ID in moderator_user_id must match the user ID in the user access token.
    public record ChannelSuspiciousUserUpdateRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelSuspiciousUserUpdateCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelSuspiciousUserUpdateNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelSuspiciousUserUpdateEvent Event { get; set; }
    }
    #endregion
}

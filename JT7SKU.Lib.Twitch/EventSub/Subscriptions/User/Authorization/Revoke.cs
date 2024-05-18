using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.User;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.User.Authorization
{
    internal class Revoke
    {
    }
    #region User.Authorization.Revoke
    // The user.authorization.revoke subscription type sends a notification when a user’s authorization has been revoked for your client id.
    // Use this webhook to meet government requirements for handling user data, such as GDPR, LGPD, or CCPA.
    // NOTE This subscription type is only supported by webhooks, and cannot be used with WebSockets.
    // Provided client_id must match the client id in the application access token.
    public record UserAuthorizationRevokeRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public UserAuthorizationRevokeCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record UserAuthorizationRevokeNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public UserAuthorizationRevokeEvent Event { get; set; }
    }
    #endregion
}

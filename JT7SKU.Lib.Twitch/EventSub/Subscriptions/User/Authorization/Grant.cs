using JT7SKU.Lib.Twitch.EventSub.Events.Stream;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Stream;
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
    internal class Grant
    {
    }
    #region User.Authorization.Grant
    // The user.authorization.grant subscription type sends a notification when a user’s authorization has been granted to your client id.
    // NOTE This subscription type is only supported by webhooks, and cannot be used with WebSockets.
    // Provided client_id must match the client id in the application access token.
    public record UserAuthorizationGrantRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public UserAuthorizationGrandCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record UserAuthorizationGrantNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public UserAuthorizationGrantEvent Event { get; set; }
    }
    #endregion
}

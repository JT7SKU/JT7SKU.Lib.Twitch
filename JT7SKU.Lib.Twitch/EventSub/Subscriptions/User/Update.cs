using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.User;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.User
{
    internal class Update
    {
    }
    #region User.Update
    // The user.update subscription type sends a notification when user updates their account.
    // No authorization required. If you have the user:read:email scope, the notification will include email field.
    public record UserUpdateRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public UserUpdateCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record UserUpdateNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public UserUpdateEvent Event { get; set; }
    }
    #endregion
}

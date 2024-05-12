using JT7SKU.Lib.Twitch.EventSub.Conditions.Automod;
using JT7SKU.Lib.Twitch.EventSub.Events.Automod;
using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Automod.Message
{
    // The automod.message.hold subscription type notifies a user if a message was caught by automod for review.
    // equires a user access token that includes the moderator:manage:automod scope.
    // The ID in the moderator_user_id condition parameter must match the user ID in the access token.
    // If app access token used, then additionally requires the moderator:manage:automod scope for the moderator.
    public class Hold
    {
    }
    public record AutoModMessageHoldRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public AutoModMessageHoldCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record AutomodMessageHoldNotificationPayload
    {
        public Subscription Subscription { get; set; }
        public AutomodMessageHoldEvent Event { get; set; }
    }
}

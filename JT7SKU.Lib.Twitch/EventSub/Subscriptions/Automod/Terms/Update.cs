using JT7SKU.Lib.Twitch.EventSub.Conditions.Automod;
using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Automod.Terms
{
    // he automod.terms.update subscription type sends a notification when a broadcaster’s automod terms are updated. Changes to private terms are not sent.
    // Requires a user access token that includes the moderator:manage:automod scope.
    // The ID in the moderator_user_id condition parameter must match the user ID in the access token.
    // If app access token used, then additionally requires the moderator:manage:automod scope for the moderator.
    // The moderator must be a moderator or broadcaster for the specified broadcaster.
    internal class Update
    {
    }
    public record AutomodTermsUpdateRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public AutomodSettingsUpdateCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record AutomodTermsUpdateNotificationPayload
    {
        public Subscription Subscription { get; set; }
        public Event Event { get; set; }
    }
}

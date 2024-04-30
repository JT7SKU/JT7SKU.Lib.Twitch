using JT7SKU.Lib.Twitch.EventSub.Conditions.Automod;
using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Automod.Settings
{
    // The automod.settings.update subscription type sends a notification when a broadcaster’s automod settings are updated.
    // Requires a user access token that includes the moderator:read:automod_settings scope.
    // The ID in the moderator_user_id condition parameter must match the user ID in the access token.
    // If app access token used, then additionally requires the moderator:read:automod_settings scope for the moderator.
    internal class Update
    {
    }
    public record AutomodSettingsUpdateRequestBody
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
    public record AutomodSettingsUpdateNotificationPayload
    {
        public Subscription Subscription { get; set; }
        public Event Event { get; set; }
    }
}

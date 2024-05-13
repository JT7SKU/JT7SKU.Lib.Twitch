using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Channel.ShieldMode;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.Moderation;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.ShieldMode;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel.Shield_Mode
{
    internal class End
    {
    }
    #region Channel.Shield Mode.End
    // Sends a notification when the broadcaster deactivates Shield Mode.
    // This event informs the subscriber that the broadcaster’s moderation settings were changed back to the broadcaster’s previous moderation settings.
    // Requires the moderator:read:shield_mode or moderator:manage:shield_mode scope.
    // If you use webhooks, the user in moderator_id must have granted your app (client ID) one of the above permissions prior to your app subscribing to this subscription type. To learn more, see the Authorization section of Create EventSub Subscription.
    // If you use WebSockets, the ID in moderator_id must match the user ID in the user access token.
    public record ChannelShieldModeEndRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ShieldModeEndCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelShieldModeEndNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ShieldModeEndEvent Event { get; set; }
    }
    #endregion
}

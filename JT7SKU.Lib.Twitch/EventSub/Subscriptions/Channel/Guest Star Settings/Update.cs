using JT7SKU.Lib.Twitch.EventSub.Events.Channel;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Channel.GuestStar;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.GuestStar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel.Guest_Star_Settings
{
    internal class Update
    {
    }
    #region Channnel.Guest Star Settings.Update
    //  The channel.guest_star_settings.update subscription type sends a notification when the host preferences for Guest Star have been updated.
    // Must have channel:read:guest_star, channel:manage:guest_star, moderator:read:guest_star or moderator:manage:guest_star scope.
    public record ChannelGuestStarSettingsUpdateRequestBody
    {

        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelGuestStarSettingsUpdateCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelGuestStarSettingsUpdateNotificationPayload
    {

        public Models.Subscription Subscription { get; set; }
        public ChannelGuestStarSettingsUpdateEvent Event { get; set; }
    }  
    #endregion
}

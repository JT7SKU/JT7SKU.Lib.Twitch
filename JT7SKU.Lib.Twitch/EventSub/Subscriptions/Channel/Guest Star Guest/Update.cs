using JT7SKU.Lib.Twitch.EventSub.Events.Channel;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Channel.GuestStar;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.GuestStar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel.Guest_Star_Guest
{
    internal class Update
    {
    }
    #region Channel.Guest Star Guest Guest.Update
    // The channel.guest_star_guest.update subscription type sends a notification when a guest or a slot is updated in an active Guest Star session.
    // Must have channel:read:guest_star, channel:manage:guest_star, moderator:read:guest_star or moderator:manage:guest_star scope.
    public record ChannelGuestStarGuestUpdateRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelGuestStarUpdateCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelGuestStarGuestUpdateNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelGuestStarUpdateEvent Event { get; set; }
    }
    #endregion
}

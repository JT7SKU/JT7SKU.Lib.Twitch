using JT7SKU.Lib.Twitch.EventSub.Events.Channel;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Conditions.Channel.GuestStar;
using JT7SKU.StreamService.KirjastoUtility.Twitch.EventSub.Events.Channel.GuestStar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.EventSub.Subscriptions.Channel.Guest_Star_Session
{
    internal class Begin
    {
    }
    #region Channel.Guest Star Sesssion.Begin
    // The channel.guest_star_session.begin subscription type sends a notification when the host begins a new Guest Star session.
    // Must have channel:read:guest_star, channel:manage:guest_star, moderator:read:guest_star or moderator:manage:guest_star scope.
    public record ChannelGuestStarSessionBeginRequestBody
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public string Version { get; set; }
        [Required]
        public ChannelGuestStarSessionBeginCondition Condition { get; set; }
        [Required]
        public Transport Transport { get; set; }
    }
    public record ChannelGuestStarSessionBeginNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelGuestStarSessionBeginEvent Event { get; set; }
    }
    #endregion
}

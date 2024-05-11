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
    internal class End
    {
    }
    #region Channel.Guest Star Sesssion.End
    // The channel.guest_star_session.end subscription type sends a notification when a running Guest Star session is ended by the host, or automatically by the system.
    // Must have channel:read:guest_star, channel:manage:guest_star, moderator:read:guest_star or moderator:manage:guest_star scope.
    public record ChannelGuestStarSessionEndRequestBody
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
    public record ChannelGuestStarSessionEndNotificationPayload
    {
        public Models.Subscription Subscription { get; set; }
        public ChannelGuestStarSessionEndEvent Event { get; set; }
    }
    #endregion
}

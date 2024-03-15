using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Guest_Star
{
    public class SendGuestStarInvite
    {
        // BETA
        // Query parameter moderator_id must match the user_id in the User-Access token
        // Requires OAuth Scope: channel:manage:guest_star or moderator:manage:guest_star
        public string SendGuestStarInviteChannelManageScope { get; set; } = "channel:manage:guest_star";
        public string SendGuestStarInviteModeratorManageScope { get; set; } = "moderator:manage:guest_star";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/guest_star/invites";
        public SendGuestStarInviteRequestQuery RequestQuery { get; set; }
        public SendGuestStarInviteResponseCodes ResponseCodes { get; set; }
    }
    public record SendGuestStarInviteRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string ModeratorId { get; set; }
        [Required]
        public string SessionId { get; set; }
        [Required]
        public string GuestId { get; set; }
    }
    public enum SendGuestStarInviteResponseCodes
    {
        BadRequest = 400,
        Forbidden = 403
    }
}

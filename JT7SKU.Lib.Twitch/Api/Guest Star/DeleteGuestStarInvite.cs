using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Guest_Star
{
    public class DeleteGuestStarInvite
    {
        // BETA
        // Query parameter moderator_id must match the user_id in the User-Access token
        // Requires OAuth Scope: channel:manage:guest_star or moderator:manage:guest_star
        public string DeleteGuestStarInviteChannelManageScope { get; set; } = "channel:manage:guest_star";
        public string DeleteGuestStarInviteModeratorManageScope { get; set; } = "moderator:manage:guest_star";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/guest_star/invites";
        public DeleteGuestStarInviteRequestQuery RequestQuery { get; set; }
        public DeleteGuestStarInviteResponseCodes ResponseCodes { get; set; }
    }
    public record DeleteGuestStarInviteRequestQuery
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
    public enum DeleteGuestStarInviteResponseCodes
    {
        BadRequest = 400,
        NotFound = 404
    }
}

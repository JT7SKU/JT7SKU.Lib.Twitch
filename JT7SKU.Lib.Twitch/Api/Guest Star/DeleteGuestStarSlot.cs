using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Guest_Star
{
    public class DeleteGuestStarSlot
    {
        // BETA
        // Query parameter moderator_id must match the user_id in the User-Access token
        // Requires OAuth Scope: channel:manage:guest_star or moderator:manage:guest_star
        public string DeleteGuestStarSlotChannelManageScope { get; set; } = "channel:manage:guest_star";
        public string DeleteGuestStarSlotModeratorManageScope { get; set; } = "moderator:manage:guest_star";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/guest_star/slot";
        public DeleteGuestStarSlotRequestQuery RequestQuery { get; set; }
        public DeleteGuestStarSlotResponseCodes ResponseCodes { get; set; }
    }
    public record DeleteGuestStarSlotRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string ModeratorId { get; set; }
        [Required]
        public string SessionId { get; set; }
        [Required]
        public string GuestId { get; set; }
        [Required]
        public string SlotId { get; set; }
        public string ShouldReInviteGuest { get; set; }
    }
    public enum DeleteGuestStarSlotResponseCodes
    {
        NoContent = 204,
        BadRequest = 400,
        Forbidden = 403,
        NotFound = 404
    }
}

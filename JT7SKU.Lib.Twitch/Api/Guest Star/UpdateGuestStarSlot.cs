using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Guest_Star
{
    public class UpdateGuestStarSlot
    {
        // BETA
        // Query parameter moderator_id must match the user_id in the User-Access token
        // Requires OAuth Scope: channel:manage:guest_star or moderator:manage:guest_star
        public string UpdateGuestStarSlotChannelManageScope { get; set; } = "channel:manage:guest_star";
        public string UpdateGuestStarSlotModeratorManageScope { get; set; } = "moderator:manage:guest_star";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/guest_star/slot";
        public UpdateGuestStarSlotRequestQuery RequestQuery { get; set; }
        public UpdateGuestStarSlotResponseCodes ResponseCodes { get; set; }
    }
    public record UpdateGuestStarSlotRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string ModeratorId { get; set; }
        [Required]
        public string SessionId { get; set; }
        [Required]
        public string SourceSlotId { get; set; }
        public string DestinationSlotId { get; set; }
    }
    public enum UpdateGuestStarSlotResponseCodes
    {
        NoContent = 204,
        BadRequest = 400
    }
}

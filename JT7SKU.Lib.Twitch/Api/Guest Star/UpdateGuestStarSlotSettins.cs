using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Guest_Star
{
    public class UpdateGuestStarSlotSettins
    {
        // BETA 
        // Query parameter moderator_id must match the user_id in the User-Access token
        // Requires OAuth Scope: channel:manage:guest_star or moderator:manage:guest_star
        #region Scopes
        public string UpdateGuestStarSlotSettingsChannelManageScope { get; set; } = "channel:manage:guest_star";
        public string UpdateGuestStarSlotSettingsModeratorManageScope { get; set; } = "moderator:manage:guest_star";
        #endregion
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/guest_star/slot_settings";
        public UpdateGuestSlotSettingsRequestQuery RequestQuery { get; set; }
        public UpdateGuestStarSlotSettinsResponseCodes ResponseCodes { get; set; }
    }
    public record UpdateGuestSlotSettingsRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string ModeratorId { get; set; }
        [Required]
        public string SessionId { get; set; }
        [Required]
        public string SlotId { get; set; }
        public bool IsAudioEnabled { get; set; }
        public bool IsVideoEnabled { get; set; }
        public bool IsAudioAvailable { get; set; }
        public bool IsVideoAvailable { get; set; }
    }
    public enum UpdateGuestStarSlotSettinsResponseCodes
    {
        NoContent = 204,
        BadRequest = 400,
        Forbidden = 403
    }
}

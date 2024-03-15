using JT7SKU.Lib.Twitch.Models;
using Orleans;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Guest_Star
{
    public class GetChannelGuestStarSettings
    {
        // BETA
        // Query parameter moderator_id must match the user_id in the User-Access token
        // Requires OAuth Scope: channel:read:guest_star, channel:manage:guest_star, moderator:read:guest_star or moderator:manage:guest_star
        #region Scopes 
        public string GetChannelGuestStarSettingsChannelReadScope { get; set; } = "channel:read:guest_star";
        public string GetChannelGuestStarSettingsChannelManageScope { get; set; } = "channel:manage:guest_star";
        public string GetChannelGuestStarSettingsModeratorReadScope { get; set; } = "moderator:read:guest_star";
        public string GetChannelGuestStarSettingsModeratorManageScope { get; set; } = "moderator:manage:guest_star";
        #endregion
        public string Client { get; set; }
        public string PathUrl { get; set; } = "/guest_star/channel_settings";
        public GetChannelGuestStarSettingsRequestQuery RequestQuery { get; set; }
        public GetChannelGuestStarSettingsResponseBody ResponseBody { get; set; }
        public GetChannelGuestStarSettingsResponseCodes ResponseCodes { get; set; }
    }
    public record GetChannelGuestStarSettingsRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string ModeratorId { get; set; }
    }
    public record GetChannelGuestStarSettingsResponseBody
    {
        public bool IsModeratorSendLiveEnabled { get; set; }
        public int SlotCount { get; set; }
        public bool IsBrowserSourceAudioEnabled { get; set; }
        public GroupLayout GroupLayout { get; set; }
        public string BrowserSourceToken { get; set; }
    }
    public enum GetChannelGuestStarSettingsResponseCodes
    {
        BadRequest = 400,
        Forbidden = 403
    }
}

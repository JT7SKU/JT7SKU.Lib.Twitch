using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Guest_Star
{
    public class UpdateChannelGuestStarSettings
    {
        //BETA
        // Query parameter broadcaster_id must match the user_id in the User-Access token
        // Requires OAuth Scope: channel:manage:guest_star
        public string UpdateChannelGuestStarSettingsChannelManageScope { get; set; } = "channel:manage:guest_star";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/guest_star/channel_settings";
        public UpdateChannelGuestStarSettingsRequestQuery RequestQuery { get; set; }
        public UpdateChannelGuestStarSettingsRequestBody RequestBody { get; set; }
        public UpdateChannelGuestStarSettingsResponseCodes ResponseCodes { get; set; }
    }
    public record UpdateChannelGuestStarSettingsRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
    }
    public record UpdateChannelGuestStarSettingsRequestBody
    {
        public bool IsModeratorSendLiveEnabled { get; set; }
        public int SlotCount { get; set; }
        public bool IsBrowserSourceAudioEnabled { get; set; }
        public GroupLayout GroupLayout { get; set; }
        public bool RegenerateBrowserSources { get; set; }
    }
    public enum UpdateChannelGuestStarSettingsResponseCodes
    {
        NoContent = 204,
        BadRequest = 400
    }
}

using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Moderation
{
    public class GetShieldModeStatus
    {
        // To receive notification when the broadcaster activates and deactivates Shield Mode,
        // subscribe to the channel.shield_mode.begin and channel.shield_mode.end subscription types.
        // Requires a user access token that includes the moderator:read:shield_mode or moderator:manage:shield_mode scope.
        public string GetShieldModeStatusModeratorReadScope { get; set; } = "moderator:read:shield_mode";
        public string GetShieldModeStatusModeratorManageScope { get; set; } = "moderator:manage:shield_mode";
        public string ClientID { get; set; }
        public string PathUrl { get; set; } = "/moderation/shield_mode";
        public GetShieldModeStatusRequestQuery RequestQuery { get; set; }
        public GetShieldModeStatusResponseBody ResponseBody { get; set; }
        public GetShieldModeStatusResponseCodes ResponseCodes { get; set; }
    }
    public record GetShieldModeStatusRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string ModeratorId { get; set; }
    }
    public record GetShieldModeStatusResponseBody
    {
        public GetShieldModeStatusData Data { get; set; }
    }
    public enum GetShieldModeStatusResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403
    }
    public record GetShieldModeStatusData
    {
        public bool IsActive { get; set; }
        public string ModeratorId { get; set; }
        public string ModeratorLogin { get; set; }
        public string ModeratorName { get; set; }
        public DateTime LastActivatedAt { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Moderation
{
    public class UpdateShieldModeStatus
    {
        // Requires a user access token that includes the moderator:manage:shield_mode scope.
        public string UpdateShieldModeStatusModeratorManageScope { get; set; } = "moderator:manage:shield_mode";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/moderation/shield_mode";
        public UpdateShieldModeStatusRequestQuery RequestQuery { get; set; }
        public UpdateShieldModeStatusRequestBody RequestBody { get; set; }
        public UpdateShieldModeStatusResponseBody ResponseBody { get; set; }
        public UpdateShieldModeStatusResponseCodes ResponseCodes { get; set; }
    }
    public record UpdateShieldModeStatusRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string ModeratorId { get; set; }
    }
    public record UpdateShieldModeStatusRequestBody
    {
        [Required]
        public bool IsActive { get; set; }
    }
    public record UpdateShieldModeStatusResponseBody
    {
        public UpdateShieldModeStatusData Data { get; set; }
    }
    public enum UpdateShieldModeStatusResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403
    }
    public record UpdateShieldModeStatusData
    {
        public bool IsActive { get; set; }
        public string ModeratorId { get; set; }
        public string ModeratorLogin { get; set; }
        public string ModeratorName { get; set; }
        public DateTime LastActivatedAt { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Moderation
{
    public class BanUser
    {
        // Requires a user access token that includes the moderator:manage:banned_users scope.
        public string BanUserModeratorManageScope { get; set; } = "moderator:manage:banned_users";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/moderation/bans";
        public BanUserRequestQuery RequestQuery { get; set; }
        public BanUserRequestBody RequestBody { get; set; }
        public BanUserResponseBody ResponseBody { get; set; }
        public BanUserResponseCodes ResponseCodes { get; set; }
    }
    public record BanUserRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string ModeratorId { get; set; }
    }
    public record BanUserRequestBody
    {
        [Required]
        public BanUserReqData Data { get; set; }
    }
    public record BanUserResponseBody
    {
        public BanUserRespData Data { get; set; }
    }
    public enum BanUserResponseCodes
    {
        OK = 200,
        BadRequst = 400,
        Unauthorized = 401,
        Forbidden = 403,
        Conflict = 409,
        TooManyRequests = 429
    }
    public record BanUserReqData
    {
        [Required]
        public string UserId { get; set; }
        public int Duration { get; set; }
        public string Reason { get; set; }
    }
    public record BanUserRespData
    {
        public string BroadcasterId { get; set; }
        public string ModeratorId { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime EndTime { get; set; }
    }
}

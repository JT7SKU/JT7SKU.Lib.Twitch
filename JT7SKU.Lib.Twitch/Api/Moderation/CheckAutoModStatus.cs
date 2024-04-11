using JT7SKU.Lib.Twitch.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Moderation
{
    public class CheckAutoModStatus
    {
        public Ratelimit Ratelimit { get; set; } // Normal: 5,50 | Affiliate: 10, 100 | Patrner: 30, 300
        // Requires a user access token that includes the moderation:read scope.
        public string CheckAutoModStatusModeratorReadScope { get; set; } = "moderation:read";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/moderation/enforcements/status";
        public CheckAutoModStatusRequestQuery RequestQuery { get; set; }
        public CheckAutoModStatusRequestBody RequestBody { get; set; }
        public CheckAutoModStatusResponseBody ResponseBody { get; set; }
        public CheckAutoModStatusResponseCodes ResponseCodes { get; set; }
    }
    public record CheckAutoModStatusRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
    }
    public record CheckAutoModStatusRequestBody
    {
        [Required]
        public CheckAutoModStatusReqData Data { get; set; }
    }
    public record CheckAutoModStatusResponseBody
    {
        public CheckAutoModStatusRespData Data { get; set; }
    }
    public enum CheckAutoModStatusResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        TooManyRequests = 429
    }
    public record CheckAutoModStatusReqData
    {
        [Required]
        public string MsgId { get; set; }
        [Required]
        public string MsgText { get; set; }
    }
    public record CheckAutoModStatusRespData
    {
        public string MsgId { get; set; }
        public bool IsPermitted { get; set; }
    }
}

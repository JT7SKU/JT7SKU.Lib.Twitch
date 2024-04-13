using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Raids
{
    public class CancelARaid
    {
        // Cancel a pending raid.
        // You can cancel a raid at any point up until the broadcaster clicks Raid Now in the Twitch UX or the 90-second countdown expires.
        // Rate Limit: The limit is 10 requests within a 10-minute window.
        // Requires a user access token that includes the channel:manage:raids scope.
        public string CancelARaidChannelManageScope { get; set; } = "channel:manage:raids";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "raids";
        public CancelARaidRequestQuery RequestQuery { get; set; }
        public CancelARaidResponseCodes ResponseCodes { get; set; }
    }
    public record CancelARaidRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
    }
    public enum CancelARaidResponseCodes
    {
        NoContent = 204,
        BadRequest = 400,
        UnAuthorized = 401,
        NotFound = 404,
        TooManyRequests = 429
    }
}

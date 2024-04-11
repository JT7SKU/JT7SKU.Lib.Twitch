using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Moderation
{
    public class RemoveChannelVIP
    {
        // If the broadcaster is removing the user’s VIP status, the ID in the broadcaster_id query parameter must match the user ID in the access token; otherwise,
        // if the user is removing their VIP status themselves, the ID in the user_id query parameter must match the user ID in the access token.
        // Rate Limits: The broadcaster may remove a maximum of 10 VIPs within a 10-second window.
        // Requires a user access token that includes the channel:manage:vips scope.
        public string RemoveChannelVIPChannelManageScope { get; set; } = "channel:manage:vips";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/channels/vips";
        public RemoveChannelVIPRequestQuery RequestQuery { get; set; }
        public RemoveChannelVIPResponseCodes ResponseCodes { get; set; }
    }
    public record RemoveChannelVIPRequestQuery
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public string BroadcasterId { get; set; }
    }
    public enum RemoveChannelVIPResponseCodes
    {
        NoContent = 204,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404,
        UnprocessableEntity = 422,
        TooManyRequests = 429
    }
}

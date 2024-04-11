using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Moderation
{
    public class AddChannelVIP
    {
        // Rate Limits: The broadcaster may add a maximum of 10 VIPs within a 10-second window.
        // Requires a user access token that includes the channel:manage:vips scope.
        public string AddChannelVIPChannelManageScope { get; set; } = "channel:manage:vips";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/channels/vips";
        public AddChannelVIPRequestQuery RequestQuery { get; set; }
        public AddChannelVIPResponseCodes ResponseCodes { get; set; }
    }
    public record AddChannelVIPRequestQuery
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public string BroadcasterId { get; set; }
    }
    public enum AddChannelVIPResponseCodes
    {
        NoContent = 204,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404,
        Conflict = 409,
        UnprocessableEntity=422,
        TooEarly = 425,
        TooManyRequests = 429
    }
}

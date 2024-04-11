using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Moderation
{
    public class RemoveChannelModerator
    {
        // Rate Limits: The broadcaster may remove a maximum of 10 moderators within a 10-second window.
        // Requires a user access token that includes the channel:manage:moderators scope.
        public string RemoveChannelModeratorChannelManageScope { get; set; } = "channel:manage:moderators";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/moderation/moderators";
        public RemoveChannelModeratorRequestQuery RequestQuery { get; set; }
        public RemoveChannelModeratorResponseCodes ResponseCodes { get; set; }
    }
    public record RemoveChannelModeratorRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string UserId { get; set; }
    }
    public enum RemoveChannelModeratorResponseCodes
    {
        NoContent = 204,
        BadRequest = 400,
        Unauthorized = 401,
        TooManyRequests = 429
    }
}

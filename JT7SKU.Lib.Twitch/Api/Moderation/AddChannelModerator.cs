using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Moderation
{
    public class AddChannelModerator
    {
        // Rate Limits: The broadcaster may add a maximum of 10 moderators within a 10-second window.
        // Requires a user access token that includes the channel:manage:moderators scope.
        public string AddChannelModeratorChannelManageScope { get; set; } = "channel:manage:moderators";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/moderation/moderators";
        public AddChannelModeratorRequestQuery RequestQuery { get; set; }
        public AddChannelModeratorResponseCodes ResponseCodes { get; set; }
    }
    public record AddChannelModeratorRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string UserId { get; set; }
    }
    public enum AddChannelModeratorResponseCodes
    {
        NoContent = 204,
        BadRequest = 400,
        Unauthorized = 401,
        UnprocessableEntity = 422,
        TooManyRequests = 429
    }
}

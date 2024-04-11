using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Moderation
{
    public class UnbanUser
    {
        // Requires a user access token that includes the moderator:manage:banned_users scope.
        public string UnbanUserModeratorManageScope { get; set; } = "moderator:manage:banned_users";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/moderation/bans";
        public UnbanUserRequestQuery RequestQuery { get; set; }
        public UnbanUserResponseCodes ResponseCodes { get; set; }
    }
    public record UnbanUserRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string ModeratorId { get; set; }
        [Required]
        public string UserId { get; set; }
    }
    public enum UnbanUserResponseCodes
    {
        NoContent = 204,
        BadRequest = 400,
        UnAuthorized = 401,
        Forbidden = 403,
        Conflict = 409,
        TooManyRequest = 429
    }
}

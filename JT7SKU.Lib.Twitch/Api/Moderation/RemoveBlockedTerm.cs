using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Moderation
{
    public class RemoveBlockedTerm
    {
        // Requires a user access token that includes the moderator:manage:blocked_terms scope.
        public string RemoveBlockedTermModeratorManageScope { get; set; } = "moderator:manage:blocked_terms";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/moderation/blocked_terms";
        public RemoveBlockedTermRequestQuery RequestQuery { get; set; }
        public RemoveBlockedTermResponseCodes ResponseCodes { get; set; }
    }
    public record RemoveBlockedTermRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string ModeratorId { get; set; }
        [Required]
        public string Id { get; set; }
    }
    public enum RemoveBlockedTermResponseCodes
    {
        NoContent = 204,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403
    }
}

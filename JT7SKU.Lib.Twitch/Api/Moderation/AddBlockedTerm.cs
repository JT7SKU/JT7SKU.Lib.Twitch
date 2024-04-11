using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Moderation
{
    public class AddBlockedTerm
    {
        // Requires a user access token that includes the moderator:manage:blocked_terms scope.
        public string AddBlockedTermModeratorManageScope { get; set; } = "moderator:manage:blocked_terms";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/moderation/blocked_terms";
        public AddBlockedTermRequestQuery RequestQuery { get; set; }
        public AddBlockedTermRequestBody RequestBody { get; set; }
        public AddBlockedTermResponseBody ResponseBody { get; set; }
        public AddBlockedTermResponseCodes ResponseCodes { get; set; }
    }
    public record AddBlockedTermRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string ModeratorId { get; set; }
    }
    public record AddBlockedTermRequestBody
    {
        [Required]
        public string Text { get; set; }
    }
    public record AddBlockedTermResponseBody
    {
        public AddBlockedTermData Data { get; set; }
    }
    public enum AddBlockedTermResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403
    }
    public record AddBlockedTermData
    {
        public string BroadcasterId { get; set; }
        public string ModeratorId { get; set; }
        public string Id { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime ExpiresAt { get; set; }
    }
}

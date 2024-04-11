using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Moderation
{
    public class GetBlockedTerms
    {
        // Requires a user access token that includes the moderator:read:blocked_terms or moderator:manage:blocked_terms scope.
        public string GetBlockedTermsModeratorReadScope { get; set; } = "moderator:read:blocked_terms";
        public string GetBlockedTermsModeratorManageScope { get; set; } = "moderator:manage:blocked_terms";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/moderation/blocked_terms";
        public GetBlockedTermsRequestQuery RequestQuery { get; set; }
        public GetBlockedTermsResponseBody ResponseBody { get; set; }
        public GetBlockedTermsResponseCodes ResponseCodes { get; set; }
    }
    public record GetBlockedTermsRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string ModeratorId { get; set; }
        public int First {  get; set; }
        public string After { get; set; }
    }
    public record GetBlockedTermsResponseBody
    {
        public GetBlockedTermsData Data { get; set; }
        public Pagination Pagination { get; set; }
    }
    public enum GetBlockedTermsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403
    }
    public record GetBlockedTermsData
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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Moderation
{
    public class ResolveUnbanRequests
    {
        // Requires a user access token that includes the moderator:manage:unban\_requests scope.
        // Query parameter moderator_id must match the user_id in theuser access token.
        public string ResolveUnbanRequestsModeratorManageScope { get; set; } = "moderator:manage:unban\\_requests";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/moderation/unban_requests";
        public ResolveUnbanRequestsRequestQuery RequestQuery { get; set; }
        public ResolveUnbanRequestsResponseBody ResponseBody { get; set; }
        public ResolveUnbanRequestsResponseCodes ResponseCodes { get; set; }
    }
    public record ResolveUnbanRequestsRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string ModeratoId { get; set; }
        [Required]
        public string UnbanUserId { get; set; }
        [Required]
        public string Status { get; set; } // resolution status 
        public string ResolutionText { get; set; }
    }
    public record ResolveUnbanRequestsResponseBody
    {
        public ResolveUnbanRequestsData Data { get; set; }
    }
    public enum ResolveUnbanRequestsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401,
        NotFound = 404
    }
    public record ResolveUnbanRequestsData
    {
        public string Id { get; set; }
        public string BroadcasterId { get; set; }
        public string BroadcasterLogin { get; set; }
        public string BroadcasterName { get; set; }
        public string ModeratorId { get; set; }
        public string ModeratorLogin { get; set; }
        public string ModeratorName { get; set; }
        public string UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserName { get; set; }
        public string Text { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ResolvedAt { get; set; }
        public string ResolutionText { get; set; }
    }
}

using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Moderation
{
    public class GetUnbanRequests
    {
        // Requires a user access token that includes the moderator:read:unban_requests or moderator:manage:unban_requests scope.
        // Query parameter moderator_id must match the user_id in the user access token.
        public string GetUnbanRequestsModeratorReadScope { get; set; } = "moderator:read:unban_requests";
        public string GetUnbanRequestsModeratorManageScope { get; set; } = "moderator:manage:unban_requests";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/moderation/unban_requests";
        public GetUnbanRequestsRequestQuery RequestQuery { get; set; }
        public GetUnbanRequestsResponseBody ResponseBody { get; set; }
        public GetUnbanRequestsResponseCodes ResponseCodes { get; set; }
    }
    public record GetUnbanRequestsRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        [Required]
        public string ModeratorId { get; set; }
        [Required]
        public string Status { get; set; } //fileter by status
        public string UserId { get; set; }
        public string After {  get; set; }
        public int First {  get; set; }
    }
    public record GetUnbanRequestsResponseBody
    {
        public GetUnbanRequestsData Data { get; set; }
        public Pagination Pagination { get; set; }
    }
    public enum GetUnbanRequestsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401
    }
    public record GetUnbanRequestsData
    {
        public string Id { get; set; }
        public string BroadcasterId { get; set;}
        public string BroadcasterName { get; set;}
        public string BroadcasterLogin { get; set;}
        public string ModeratorId { get; set;}
        public string ModeratorName { get; set;}
        public string ModeratorLogin { get; set;}
        public string UserId { get; set;}
        public string UserName { get; set;}
        public string UserLogin { get; set;}
        public string Text { get; set;}
        public string Status { get; set;}
        public DateTime CreatedAt { get; set;}
        public DateTime ResolvedAt { get; set;}
        public string ResolutionText { get; set;}
    }
}

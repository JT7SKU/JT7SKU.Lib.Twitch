using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Moderation
{
    public class GetBannedUsers
    {
        // Gets all users that the broadcaster banned or put in a timeout.
        // Requires a user access token that includes the moderation:read or moderator:manage:banned_users scope.
        public string GetBannedUsersModerationReadScope { get; set; } = "moderation:read";
        public string GetBannedUsersModeratorManageScope { get; set; } = "moderator:manage:banned_users scope";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/moderation/banned";
        public GetBannedUsersRequestQuery RequestQuery { get; set; }
        public GetBannedUsersResponseBody ResponseBody { get; set; }
        public GetBannedUsersResponseCodes ResponseCodes { get; set; }
    }
    public record GetBannedUsersRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        public string UserId { get; set; }
        public int First {  get; set; }
        public string After { get; set; }
        public string Before { get; set; }
    }
    public record GetBannedUsersResponseBody
    {
        public GetBannedUsersData Data { get; set; }
        public Pagination Pagination { get; set; }
    }
    public enum GetBannedUsersResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401
    }
    public record GetBannedUsersData
    {
        public string UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserName { get; set; }
        public DateTime ExpiresAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Reason { get; set; }
        public string ModeratorId { get; set; }
        public string ModeratorName { get; set; }
    }
}

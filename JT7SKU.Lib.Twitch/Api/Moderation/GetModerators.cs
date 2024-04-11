using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Moderation
{
    public class GetModerators
    {
        // Requires a user access token that includes the moderation:read scope.
        // If your app also adds and removes moderators, you can use the channel:manage:moderators scope instead.
        public string GetModeratorsModerationReadScope { get; set; } = "moderation:read";
        public string GetModeratorsChannelManageScope { get; set; } = "channel:manage";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/moderation/moderators";
        public GetModeratorsRequestQuery RequestQuery { get; set; }
        public GetModeratorsResponseBody ResponseBody { get; set; }
        public GetModeratorsResponseCodes ResponseCodes { get; set; }
    }
    public record GetModeratorsRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        public string UserId { get; set; }
        public string First {  get; set; }
        public string After { get; set; }
    }
    public record GetModeratorsResponseBody
    {
        public GetModeratorsData Data { get; set; }
        public Pagination Pagination { get; set; }
    }
    public enum GetModeratorsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauhorized = 401
    }
    public record GetModeratorsData
    {
        public string UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserName { get; set; }
    }
}

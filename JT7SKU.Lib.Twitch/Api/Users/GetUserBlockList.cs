using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Users
{
    public class GetUserBlockList
    {
        // Gets the list of users that the broadcaster has blocked. 
        // Requires a user access token that includes the user:read:blocked_users scope.
        public string GetUserBlockListUserReadScope { get; set; } = "user:read:blocked_users";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/users/blocks";
        public GetUserBlockListRequestQuery RequestQuery { get; set; }
        public GetUserBlockListResponseBody ResponseBody { get; set; }
        public GetUserBlockListResponseCodes ResponseCodes { get; set; }
    }
    public record GetUserBlockListRequestQuery
    {
        [Required]
        public string BroadcasterId { get; set; }
        public int First { get; set; }
        public string After { get; set; }
    }
    public record GetUserBlockListResponseBody
    {
        public List<GetUserBlockLitRespData> Data { get; set; }
    }
    public enum GetUserBlockListResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401
    }
    public record GetUserBlockLitRespData
    {
        public string UserId { get; set; }
        public string UserLogin { get; set; }
        public string DisplayName { get; set; }
    }
}

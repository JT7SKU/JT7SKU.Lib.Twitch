using JT7SKU.Lib.Twitch.Api.Moderation;
using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Users
{
    public class GetUsers
    {
        // Gets information about one or more users.
        // You may look up users using their user ID, login name, or both but the sum total of the number of users you may look up is 100.
        // For example, you may specify 50 IDs and 50 names or 100 IDs or names, but you cannot specify 100 IDs and 100 names.
        // If you don’t specify IDs or login names, the request returns information about the user in the access token if you specify a user access token.
        // To include the user’s verified email address in the response, you must use a user access token that includes the user:read:email scope.
        // Requires an app access token or user access token.
        public string GetUsersUserReadScope { get; set; } = "user:read:email";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/users";
        public GetUsersRequestQuery RequestQuery { get; set; }
        public GetUsersResponseBody ResponseBody { get; set; }
        public GetUsersResponseCodes ResponseCodes { get; set; }
    }
    public record GetUsersRequestQuery
    {
        public string Id { get; set; }
        public string Login {  get; set; }
    }
    public record GetUsersResponseBody
    {
        public List<GetUsersRespData> Data {  get; set; } 
    }
    public enum GetUsersResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        UnAuthorized = 401
    }
    public record GetUsersRespData
    {
        public string Id { set; get; }
        public string Login { get; set; }
        public string DisplayName { get; set; }
        public UserType Type { get; set; }
        public BroadcasterType BroadcasterType { get; set; }
        public string Description { get; set; }
        public string ProfileImageUrl { get; set; }
        public string OfflineImageUrl { get; set; }
        public int ViewCount { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

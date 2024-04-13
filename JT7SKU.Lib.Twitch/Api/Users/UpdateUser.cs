using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Users
{
    public class UpdateUser
    {
        // Updates the specified user’s information. The user ID in the OAuth token identifies the user whose information you want to update.
        // To include the user’s verified email address in the response, the user access token must also include the user:read:email scope.
        // Requires a user access token that includes the user:edit scope.
        public string UpdateUserUserEditScope { get; set; } = "user:edit";
        public string UpdateUserUserReadScope { get; set; } = "user:read:email";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/users";
        public UpdateUserRequestQuery RequestQuery { get; set; }
        public UpdateUserResponseBody ResponseBody { get; set; }
        public UpdateUserResponseCodes ResponseCodes { get; set; }
    }
    public record UpdateUserRequestQuery
    {
        public string Descpription { get; set; }
    }
    public record UpdateUserResponseBody
    {
        public List<UpdateUserRespData> Data { get; set; }
    }
    public enum UpdateUserResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401
    }
    public record UpdateUserRespData
    {
        public string Id { get; set; }
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

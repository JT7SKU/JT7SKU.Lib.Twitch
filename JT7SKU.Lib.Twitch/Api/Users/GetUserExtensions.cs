using JT7SKU.Lib.Twitch.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Users
{
    public class GetUserExtensions
    {
        // Gets a list of all extensions (both active and inactive) that the broadcaster has installed. The user ID in the access token identifies the broadcaster.
        // Requires a user access token that includes the user:read:broadcast or user:edit:broadcast scope.
        // To include inactive extensions, you must include the user:edit:broadcast scope.
        public string GetUserExtensionsUserReadScope { get; set; } = "user:read:broadcast";
        public string GetUserExtensionsUserEditScope { get; set; } = " user:edit:broadcast";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/users/extensions/list";
        public GetUserExtensionsResponseBody ResponseBody { get; set; }
        public GetUserExtensionsResponseCodes ResponseCodes { get; set; }
    }
    public record GetUserExtensionsResponseBody
    {
        public List<GetUserExtensionsRespData> Data { get; set; }
    }
    public enum GetUserExtensionsResponseCodes
    {
        OK = 200,
        Unauthorized = 401
    }
    public record GetUserExtensionsRespData
    {
        public string Id { get; set; }
        public string Version { get; set; }
        public string Name { get; set; }
        public bool CanActivate { get; set; }
        public ExtensionType Type { get; set; }
    }
}

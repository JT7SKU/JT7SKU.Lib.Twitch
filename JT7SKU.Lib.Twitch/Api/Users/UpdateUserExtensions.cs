using JT7SKU.Lib.Twitch.Models;
using Orleans.Streams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Users
{
    public class UpdateUserExtensions
    {
        // Updates an installed extension’s information.
        // You can update the extension’s activation state, ID, and version number.
        // The user ID in the access token identifies the broadcaster whose extensions you’re updating.
        // NOTE: If you try to activate an extension under multiple extension types, the last write wins (and there is no guarantee of write order).
        // Requires a user access token that includes the user:edit:broadcast scope.
        public string UpdateUserExtensionsUserReadScope { get; set; } = "user:edit:broadcast";
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/users/extensions";
        public UpdateUserExtensionsRequestBody RequestBody { get; set; }
        public UpdateUserExtensionsResponseBody ResponseBody { get; set; }
        public UpdateUserExtensionsResponseCodes ResponseCodes { get; set; }
    }
    public record UpdateUserExtensionsRequestBody
    {
        public Dictionary<string,string> Data { get; set; }
    }
    public record UpdateUserExtensionsResponseBody
    {
        public UpdateUserExtensionsRespData Data { get; set; }
    }
    public enum UpdateUserExtensionsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401,
        NotFound = 404
    }
    public record UpdateUserExtensionsRespData
    {
        public ExtensionPanel Panel { get; set; }
        public ExtensionVideoOverlay Overlay { get; set; }
        public ExtensionComponent Component { get; set; }
    }
}

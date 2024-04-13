using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Users
{
    public class GetUserActiveExtensions
    {
        // Gets the active extensions that the broadcaster has installed for each configuration.
        // NOTE: To include extensions that you have under development,
        // you must specify a user access token that includes the user:read:broadcast or user:edit:broadcast scope.
        // Requires an app access token or user access token.
        public string GetUserActiveExtensionsUserReadScope { get; set; } = "user:read:broadcast";
        public string GetUserActiveExtensionsUserEditScope { get; set; } = "user:edit:broadcast";
        public GetUserActiveExtensionsRequestQuery RequestQuery { get; set; }
        public GetUserActiveExtensionsResponseBody ResponseBody { get; set; }
        public GetUserActiveExtensionsResponseCodes ResponseCodes { get; set; }
    }
    public record GetUserActiveExtensionsRequestQuery
    {
        public string UserId { get; set; }
    }
    public record GetUserActiveExtensionsResponseBody
    {
        public GetUserActiveExtensionsRespData Data { get; set; }
    }
    public enum GetUserActiveExtensionsResponseCodes
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized = 401
    }
    public record GetUserActiveExtensionsRespData
    {
        public ExtensionPanel Panel { get; set; }
        public ExtensionVideoOverlay Overlay { get; set; }
        public ExtensionComponent Component { get; set; }
    }
}


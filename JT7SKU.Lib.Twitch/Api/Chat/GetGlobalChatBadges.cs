using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Chat
{
    public class GetGlobalChatBadges
    {
        // Requires an app access token or user access token.
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/chat/badges/global";
        public GetGlobalChatBadgesResponseBody ResponseBody { get; set; }
        public GetGlobalChatBadgesResponseCodes ResponseCodes { get; set; }
    }
    public record GetGlobalChatBadgesResponseBody
    {
        public GetChannelChatBadgesData Data { get; set; }
    }
    public enum GetGlobalChatBadgesResponseCodes
    {
        OK = 200,
        Unauthorized = 401
    }
    public record GetGlobalChatBadgesData
    {
        public string SetId { get; set; }
        public BadgesVersions Versions { get; set; }
    }
}

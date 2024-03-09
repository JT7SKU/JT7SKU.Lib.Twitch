using JT7SKU.Lib.Twitch.EventSub;
using JT7SKU.Lib.Twitch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JT7SKU.Lib.Twitch.Api.Chat
{
    public class GetGlobalEmotes
    {
        // Authorization Requires App Access Token or User Access Token
        public string ClientId { get; set; }
        public string PathUrl { get; set; } = "/chat/emotes/global";
        public GetGlobalEmotesResponseBody ResponseBody { get; set; }
        public GetGlobalEmotesResponseCodes ResponseCodes { get; set; }
    }
    public record GetGlobalEmotesResponseBody
    {
        public GetChannelEmotesData Data { get; set; }
        public string Template { get; set; }
    }
    public enum GetGlobalEmotesResponseCodes
    {
        OK=200,
        Unauthorized=401
    }
    public record GetGlobalEmotesData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Image Images { get; set; }
        public EmoteFormat Format { get; set; }
        public EmoteScale Scale { get; set; }
        public ThemeMode ThemeMode { get; set; }
    }
}
